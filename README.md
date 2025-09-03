# PointsBet_Backend_Online_Code_Test
This is a simple folder containing a `StringFormatter.cs` file for code enhancement.

For candidates, please follow the below points to complete the test:
- Read the `README.md` file in the root directory, which should be the same file you are reading now. :)
- Go to the `README.md` file
  - Read the comment in the `StringFormatter.cs` file
  - Follow the instructions in the comment to complete the task
- Once complete your solution, please submit the codebase to your GitHub and share the public link with our HR team

## Key Improvements Made

- Fixed typo in method name: `ToCommaSepatatedList` -> `ToCommaSeparatedList`
- Replaced StringBuilder loop with `string.Join()` and LINQ for cleaner code
- Added input validation (null/empty array checks)
- Used string interpolation instead of `string.Format()`
- Made quote parameter default to `"` since that's most common
- Handle null items in array safely

Thank you for completing the code test with PointsBet.