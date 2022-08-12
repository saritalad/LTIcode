import { TestBed } from '@angular/core/testing';

import { DataguardGuard } from './dataguard.guard';

describe('DataguardGuard', () => {
  let guard: DataguardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(DataguardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
