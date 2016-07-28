import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-fetch-client";
import 'fetch';

@inject(HttpClient)
export class PersonApi {
    baseUrl = "http://localhost:2900/api";

    constructor(httpClient) {
        this.httpClient = httpClient;
    }

    //Here you can initiate something when page activates.
    activate() {

    }

    getAll() {
        return this.httpClient.fetch(`${this.baseUrl}/persons`)
           .then(response => response.json());
    }
}