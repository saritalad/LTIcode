import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MystrdirectiveComponent } from './mystrdirective.component';

describe('MystrdirectiveComponent', () => {
  let component: MystrdirectiveComponent;
  let fixture: ComponentFixture<MystrdirectiveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MystrdirectiveComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MystrdirectiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
