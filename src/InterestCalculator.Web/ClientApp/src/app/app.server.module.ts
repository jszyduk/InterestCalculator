import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
import { ModuleMapLoaderModule } from '@nguniversal/module-map-ngfactory-loader';
import { from } from 'rxjs';
import { AppComponent } from './app.component';
import { AppModule } from './app.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [AppModule, ServerModule, ModuleMapLoaderModule, ReactiveFormsModule],
    bootstrap: [AppComponent]
})
export class AppServerModule { }
