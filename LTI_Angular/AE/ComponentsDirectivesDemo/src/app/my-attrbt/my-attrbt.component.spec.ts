import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyAttrbtComponent } from './my-attrbt.component';

describe('MyAttrbtComponent', () => {
  let component: MyAttrbtComponent;
  let fixture: ComponentFixture<MyAttrbtComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MyAttrbtComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MyAttrbtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
