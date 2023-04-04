import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SlidShowComponent } from './slid-show.component';

describe('SlidShowComponent', () => {
  let component: SlidShowComponent;
  let fixture: ComponentFixture<SlidShowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SlidShowComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SlidShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
