import { Component } from '@angular/core';

@Component({
    templateUrl: './integrations.component.html'
})
export class IntegrationsComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
