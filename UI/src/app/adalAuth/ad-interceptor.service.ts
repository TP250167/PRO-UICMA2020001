import { Injectable } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest } from '@angular/common/http';
import { Observable, from } from 'rxjs';
import { mergeMap } from 'rxjs/operators';

import { AdAuthService } from './ad-auth.service'

@Injectable()

export class AdInterceptorService implements HttpInterceptor {

  constructor(private ads: AdAuthService) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    const resource = this.ads.adsf.getResourceForEndpoint(request.url);

    const skipAdal = request.headers.get('skip-adal');

    if (!resource || skipAdal) { return next.handle(request); }

    if (!this.ads.userInfo.authenticated) { throw new Error('Cannot send request to registered endpoint if the user is not authenticated.'); }
    
    return this.ads.adsf.acquireToken(resource)
      .pipe(
        mergeMap((token: string) => {
          const authorizedRequest = request.clone({
            headers: request.headers
              .set('Authorization', `Bearer ${token}`),
          });
          return next.handle(authorizedRequest);
        }
        )
      )

  }
}