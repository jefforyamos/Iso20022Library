# Release Command

You are helping the user create a new release of the BeneficialStrategies.Iso20022 NuGet package.

## Step 1: Run Tests

First, run all unit tests. If any tests fail, stop immediately and report the failures.

```bash
cd src && dotnet test BeneficialStrategies.Iso20022.Common.Tests --verbosity minimal
```

If tests fail, tell the user: "Release aborted: Tests failed. Please fix the failing tests before releasing."

## Step 2: Show Current State

Show the user:
1. Current version from `src/BeneficialStrategies.Iso20022.Common/BeneficialStrategies.Iso20022.Common.csproj` (look for `<Version>` tag)
2. Last git tag: `git describe --tags --abbrev=0 2>/dev/null || echo "No tags found"`
3. Commits since last tag: `git log $(git describe --tags --abbrev=0 2>/dev/null)..HEAD --oneline 2>/dev/null || git log --oneline -10`

## Step 3: Ask for Release Details

Use the AskUserQuestion tool to ask:

**Question 1: Version Bump Type**
- Header: "Version"
- Question: "What type of version bump is this release?"
- Options:
  - "Patch (bug fixes)" - for backwards-compatible bug fixes
  - "Minor (features)" - for new backwards-compatible functionality
  - "Major (breaking)" - for breaking changes
  - "Custom" - to specify exact version

**Question 2: Release Notes**
After getting the version type, ask:
- Header: "Notes"
- Question: "What should the release notes say? (Brief summary of changes)"
- This should be free text, so provide example options they can modify

## Step 4: Calculate New Version

Parse the current version (format: X.Y.Z-alpha or X.Y.Z) and calculate new version:
- Patch: increment Z
- Minor: increment Y, reset Z to 0
- Major: increment X, reset Y and Z to 0
- Keep any suffix like "-alpha" unless user specifies otherwise

Show the user the new version and ask for confirmation.

## Step 5: Update Files

1. **Update .csproj version**: Edit `src/BeneficialStrategies.Iso20022.Common/BeneficialStrategies.Iso20022.Common.csproj` to update the `<Version>` tag

2. **Update release-notes.txt**: Prepend the new version and notes to `src/BeneficialStrategies.Iso20022.Common/release-notes.txt` following the existing format:
   ```
   X.Y.Z-alpha
       Description of changes.
       Additional details if needed.
   ```

## Step 6: Commit and Tag

```bash
cd src && git add BeneficialStrategies.Iso20022.Common/BeneficialStrategies.Iso20022.Common.csproj BeneficialStrategies.Iso20022.Common/release-notes.txt
git commit -m "Release vX.Y.Z-alpha

Release notes:
- Summary of changes

Co-Authored-By: Claude Opus 4.5 <noreply@anthropic.com>
Assisted-By: BeneficialStrategies Iso20022 MCP Server"

git tag -a vX.Y.Z-alpha -m "Release vX.Y.Z-alpha"
```

## Step 7: Build Package

```bash
cd src && dotnet pack BeneficialStrategies.Iso20022.Common -c Release
```

Show the user the path to the generated .nupkg file.

## Step 8: Ask About Publishing

Use AskUserQuestion to ask:
- Header: "Publish"
- Question: "What would you like to do next?"
- Options:
  - "Push tag & publish to NuGet" - pushes git tag and publishes package
  - "Push tag only" - pushes git tag, does not publish to NuGet
  - "Done for now" - leaves everything local, user will push/publish later

If pushing tag:
```bash
git push origin vX.Y.Z-alpha
```

If publishing to NuGet:
```bash
dotnet nuget push src/BeneficialStrategies.Iso20022.Common/bin/Release/BeneficialStrategies.Iso20022.X.Y.Z-alpha.nupkg --api-key $NUGET_API_KEY --source https://api.nuget.org/v3/index.json
```

Note: If NUGET_API_KEY is not set, inform the user they need to set it or provide it.

## Summary

At the end, provide a summary:
- New version number
- Git tag created
- Package location
- What was pushed/published (if anything)
- Next steps if they chose "Done for now"
