import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpResponse, HttpHandler, HttpEvent, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { mergeMap } from 'rxjs/operators';
import { map, catchError } from 'rxjs/operators';

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

          return next.handle(authorizedRequest).pipe(
            map((event: HttpEvent<any>) => {
                if (event instanceof HttpResponse) {
                  let sucessData = {
                    url : event.url,
                    statusText : event.statusText,
                    statusCode : event.status,
                    data : event.body
                  }
                    console.log('sucessData--->>>',sucessData);
                }
                return event;
            }),
            catchError((error: HttpErrorResponse) => {
                let errorData = {
                    reason: error.message,
                    status: error.status
                };
                console.log('errorData--->>>',errorData)
                return throwError(error);
            }));

        }
        )
      )

  }
}