import {inject} from "aurelia-framework";
import {Router} from "aurelia-router";

@inject(Router)
export class App {

    configureRouter(config, router) {
        config.title = 'Aurelia';
        config.map([
          { route:  ['', 'welcome'], name: 'welcome', moduleId: 'welcome', nav: true, title: 'Welcome' },
          { route:  'persons', name: 'person', moduleId: 'person', nav: true, title: 'Persons' }
        ]);

        this.router = router;
    }
}
