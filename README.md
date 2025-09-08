# PointsBet_Backend_Online_Code_Test
This is a simple folder containing a `StringFormatter.cs` file for code enhancement.

For candidates, please follow the below points to complete the test:
- Read the `README.md` file in the root directory, which should be the same file you are reading now. :)
- Go to the `README.md` file
  - Read the comment in the `StringFormatter.cs` file
  - Follow the instructions in the comment to complete the task
- Once complete your solution, please submit the codebase to your GitHub and share the public link with our HR team

## Key Improvements Made / Changelog

- Fixed typo in method name: `ToCommaSepatatedList` -> `ToCommaSeparatedString`
- Updated method to accept `IEnumerable<string>` instead of `string[]` for more flexibility
- Added `MaxItemLength` constant to enforce maximum item length (1024 characters)
- Input validation:
  - Ensures `items` collection is not null
  - Ensures `quote` is not null, empty, or whitespace
  - Ensures `quote` is a single non-alphanumeric character
- Skips invalid items:
  - null, empty, or whitespace-only items
  - items exceeding `MaxItemLength`
- Trims each item before wrapping it in the quote character
- Efficiently builds the result using `StringBuilder`
- Returns a **comma-separated string** of valid, quoted items

Thank you for completing the code test with PointsBet.