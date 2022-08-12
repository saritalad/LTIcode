import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertbingingComponent } from './propertbinging.component';

describe('PropertbingingComponent', () => {
  let component: PropertbingingComponent;
  let fixture: ComponentFixture<PropertbingingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PropertbingingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PropertbingingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
