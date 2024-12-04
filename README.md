# Random Number Generator

A simple Windows Forms Application that generates a user-specified number of random numbers, saves them to a file, and allows the user to choose the file's location and name.

---

## Features

- **Random Number Generation**: Generates a specified number of random integers between 1 and 100.
- **Save to File**: Outputs the generated numbers to a text file.
- **User-Specified File Location**: Allows the user to choose the file name and save location using a `SaveFileDialog`.
- **Input Validation**: Ensures the user enters a valid positive integer for the number of random numbers.

---

## How to Use

1. **Input the Number of Random Numbers**:
   - Enter a positive integer in the textbox labeled `Number of Randoms`.

2. **Generate Numbers**:
   - Click the **Generate** button.
   - A `Save File` dialog will open, allowing you to choose where to save the file.

3. **Save the File**:
   - Choose a file name and location in the `Save File` dialog, and click **Save**.
   - The program will generate the random numbers and save them to the file.

4. **Output**:
   - A confirmation message will be displayed in the form.
   - The saved file will contain one random number per line.

---

## Example Output File

If you specify **5 random numbers**, the file might look like this:

12 89 45 67 23


---

## Requirements

- **Operating System**: Windows
- **Development Environment**: Visual Studio (Windows Forms Application)
- **.NET Framework**: 4.7.2 or higher

---

## How to Run

1. Clone or download this repository to your local machine.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build and run the project.
4. Follow the instructions in the application to generate and save random numbers.

---

## File Descriptions

- **`Form1.cs`**: Contains the main logic for the application, including number generation, file saving, and user interactions.
- **`Program.cs`**: Entry point for the application.

---

## Error Handling

- If the user enters an invalid input (non-numeric or less than 1), an error message is displayed.
- If there’s an issue saving the file (e.g., permission denied), an error message is shown with details.

---

## Possible Enhancements

- Allow users to specify the range of random numbers.
- Add a progress indicator for large sets of numbers.
- Provide an option to append to an existing file instead of overwriting it.
