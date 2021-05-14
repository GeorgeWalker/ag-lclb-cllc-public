import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-drink-amounts',
  templateUrl: './drink-amounts.component.html',
  styleUrls: ['./drink-amounts.component.scss']
})
export class DrinkAmountsComponent implements OnInit {
  @Output() saved: EventEmitter<{declaredServings: number}> = new EventEmitter<{declaredServings: number}>();
  @Output() back: EventEmitter<boolean> = new EventEmitter<boolean>();
  form: FormArray;
  
  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.form = this.fb.array([]);
  }

  next() {
    this.saved.next(<any>{});
  }
}
