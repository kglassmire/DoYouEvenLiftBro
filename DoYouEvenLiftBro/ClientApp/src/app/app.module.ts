import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DoYouEvenLiftBroMaterialModule } from './material-module';
import { AppRoutingModule } from './app-routing.module';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { WorkoutsComponent } from './components/workouts/workouts.component';
import { ExercisesComponent } from './components/exercises/exercises.component';
import { FriendsComponent } from './components/friends/friends.component';
import { SettingsComponent } from './components/settings/settings.component';
import { LiftProgressChartComponent } from './components/lift-progress-chart/lift-progress-chart.component';
import { LoginReactiveComponent } from './components/login-reactive/login-reactive.component';
import { ChartsModule } from 'ng2-charts';
import { AuthenticationService, COOKIE_NAME } from './services/authentication.service';
import { environment } from '../environments/environment';
import { AlertService } from './services/alert.service';
import { AuthService } from './services/api.service';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { CustomInterceptor } from './credential-http-interceptor';
import { AlertComponent } from './components/alert/alert.component';
import { SidenavMenuComponent } from './components/sidenav-menu/sidenav-menu.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    WorkoutsComponent,
    ExercisesComponent,
    FriendsComponent,
    SettingsComponent,
    LiftProgressChartComponent,
    AlertComponent,
    LoginReactiveComponent,
    SidenavMenuComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    DoYouEvenLiftBroMaterialModule,
    ChartsModule,
    ReactiveFormsModule
  ],
  providers: [
    AuthenticationService,
    AlertService,
    AuthService,
    {provide: COOKIE_NAME, useValue: environment.cookieName},
    {provide: HTTP_INTERCEPTORS, useClass: CustomInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
