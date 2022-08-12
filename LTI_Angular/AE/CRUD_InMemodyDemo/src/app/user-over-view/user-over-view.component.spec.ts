import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserOverViewComponent } from './user-over-view.component';

describe('UserOverViewComponent', () => {
  let component: UserOverViewComponent;
  let fixture: ComponentFixture<UserOverViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserOverViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserOverViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
