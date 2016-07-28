import {inject} from "aurelia-framework";
import {PersonApi} from "person-api";

@inject(PersonApi)
export class App {
    message = 'Welcome to Aurelia!';
    persons = [];

    constructor(personApi) {
        this.personApi = personApi;
    }

    activate() {
        this.getPersons();
    }

    getPersons() {
        this.personApi.getAll().then(persons => {
            this.persons = persons;
        });
    }
}
