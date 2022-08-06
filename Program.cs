using LinkedIn.Essentials;


// using Types to cast variables
IPerson e = new ShiftWorker();
e.FirstName = "Edge";
((ShiftWorker)e).ShiftStartTime = new TimeOnly(8, 30);


