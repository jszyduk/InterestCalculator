import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoanResult } from 'src/app/entities/loanResult';
import { Loan } from 'src/app/entities/loan';
import { PaybackStrategy } from 'src/app/utils/PaybackStrategy';


@Component({
  selector: 'app-house-loan',
  templateUrl: './house-loan.component.html',
  styleUrls: ['./house-loan.component.css']
})
export class HouseLoanComponent {
  
  public loanCost: LoanResult;
  public loan = new Loan();
  public error = false;
  public exceptionMessage: '';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    
  }

  receiveLoanData($event) {
    this.error = false;
    this.loan = $event;
    this.callApi();
  }

  callApi() {
    this.http.get<LoanResult>(`${this.baseUrl}houseloan/${this.loan.amount}/${this.loan.years}/${PaybackStrategy.Steady}`).subscribe(result => {
      this.loanCost = result;
    },
      e => {
        this.error = true;
        this.exceptionMessage = e !== null ? e.error : 'Something went wrong...';
        console.error(e);
      });
  }

  onTestClick(): void {
    console.log(this.loan);
  }
}
