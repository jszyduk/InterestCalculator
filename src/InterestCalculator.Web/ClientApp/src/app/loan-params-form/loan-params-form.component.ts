import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { Loan } from 'src/app/entities/loan';

@Component({
  selector: 'app-loan-params-form',
  templateUrl: './loan-params-form.component.html',
  styleUrls: ['./loan-params-form.component.css']
})
export class LoanParamsFormComponent implements OnInit {
  
  loanParamsForm: FormGroup;
  @Output() loanEvent = new EventEmitter<Loan>();

  public loan = new Loan();

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.initializeForm();
  }

  initializeForm(): void {
    this.loanParamsForm = this.fb.group({
      amount: [100000, Validators.required],
      years: [25, Validators.required],
    });
  }

  onSubmit(): void {
    this.loan.amount = parseFloat(this.loanParamsForm.get("amount").value);
    this.loan.years = Number(this.loanParamsForm.get("years").value);
    this.loanEvent.emit(this.loan);
  }

}
