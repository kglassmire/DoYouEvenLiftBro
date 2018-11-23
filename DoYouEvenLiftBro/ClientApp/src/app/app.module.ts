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
import { ChartsModule } from 'ng2-charts';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    WorkoutsComponent,
    ExercisesComponent,
    FriendsComponent,
    SettingsComponent,
    LiftProgressChartComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    DoYouEvenLiftBroMaterialModule,
    ChartsModule
  ],
  providers: [  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
