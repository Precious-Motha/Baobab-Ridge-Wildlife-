# Baobab Ridge Wildlife Rehabilitation Records System



#### **Project Overview**

The Baobab Ridge Wildlife Rehabilitation Record System is a C# Windows Forms desktop application designed to help a wildlife rehabilitation centre manage animal records and monitor their recovery progress. The system allows users to add, view, update and delete animal records. Animal information is stored in plain text files, while Git and GitHub are used to manage the project's source code and development history.



#### **Group Members**

1. Precious Motha(603981)
2. Chabeli Peter Rathulo(604046)
3. Christiaan De Jagar(603754)
4. Cj Bruwer(603655)



#### **Project Status**



Initial project setup. Features will be added as development progresses.



#### **Requirements**



* Programming language: C#
* User interface: Windows Forms
* Framework: .NET 8.0 or newer
* Development environment: Visual Studio
* Version control: Git and GitHub
* Data storage: Plain text files; no database.

#### **Build and Run**



1. Instal Visual Studio with the .NET desktop development workload.
2. Clone the GitHub repository.
3. Open BaobabRidge.slnx in Visual Studio.
4. Allow The project dependencies to restore.
5. Build the solution.
6. Run the application from Visual Studio

#### 

#### **Features**



* Add Animal: Enter animal details, validate the information, and calculate status and housing unit.
* View Animal: Display animal records in a read-only table
* Update Animal: Find and Update an existing animal's details.
* Delete Animal: Remove an animal after confirmation
* Summary Report: Display animal totals, average age, average recovery score, and counts for each status.



#### **Data Formats**

**Animals.txt**

* Stores one animal per line
* Uses UTF-8 text encoding
* Uses the pipe character (|) to separate seven fields in this order:

&#x20;  *ID | Name | Species | Age | Score | Status | Housing*

* Includes starter records supplied with the project.
* Is stored alongside the running application.



**Summary.txt**

* Generated when the summary report is created.
* Contains the report timestamp, total animals, averages, and counts per status.
* Is overwritten when a new summary is generated.
* Is generated beside the running application and does not need to be committed to Git.



#### **Error Handling**

Input validation: Rejects invalid or missing values with a clear message.

Animal ID validation: Checks required format and uniqueness.

Missing Data File: Creates animal.txt if does not exist.

Malformed records: Skips malformed lines and reports how many were skipped.

File access errors: Handles file problems without crashing

Update and Delete operations: Reports missing animals and confirms deletions.

Summery report: Handles empty records and displays N/A for averages.





#### 

#### **Known Limitations** 



The application is currently at the initial setup stage.

