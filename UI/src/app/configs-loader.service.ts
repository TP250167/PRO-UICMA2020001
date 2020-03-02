import { Injectable } from '@angular/core';
import { HttpClient, HttpBackend } from '@angular/common/http';


export interface Configs {
    isTest: boolean,
    apiURL: string,
    adalConfig: AdalConfig
}
export interface AdalConfig {
    tenant: string,
    clientId: string,
    endpoints: any,
    postLogoutRedirectUri: string,
    cacheLocation: string
}


@Injectable({
    providedIn: 'root'
})




export class ConfigsLoaderService {

    private httpClient: HttpClient;
    private configs: Configs;

    constructor(handler: HttpBackend) {
        this.httpClient = new HttpClient(handler);
    }

    get ApiUrl() {
        return this.configs.apiURL;
    }
    get Config() {
        return this.configs;
    }
    get isTest() {
        return this.configs.isTest;
    }

    public async loadConfigs(): Promise<any> {
        return this.httpClient.get('assets/configs.json').pipe(settings => settings)
            .toPromise()
            .then(settings => {
                this.configs = settings as Configs;
            });
    }

}

