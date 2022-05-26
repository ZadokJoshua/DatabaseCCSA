-- Extract all patients seen by a specific doctor on a particular day
SELECT * 
FROM Patients 
WHERE Appointment_Day = "Monday";

-- Extract all patients seen weekly, monthly, quarterly and yearly
SELECT * 
FROM Patients 
WHERE Appointment_Schedule = "weekly" AND Appointment_Schedule = "monthly" AND Appointment_Schedule = "quarterly" AND Appointment_Schedule = "yearly";

-- Extract all doctors in the hospital
SELECT doctors
FROM hospital;

-- Extract all hospital patients
SELECT Patients 
FROM Hospital;

-- Extract all registered hospital patients
SELECT Patients
FROM Hospital
WHERE registration_status = true;

-- Extract every patient owing the hospital
SELECT Patients 
FROM Hospital
WHERE payment_status = true;

-- Extract the top 10 drugs that are mostly bought**
