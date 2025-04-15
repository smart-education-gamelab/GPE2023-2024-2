# Code Conventions & Repository Management

This document outlines the code conventions and repository management practices that should be followed when contributing to the project.

## Conventions

The codebase of the project should adhere to the following coding style:

- `Code conventions:` for our code conventions we decided on using [Common C# code conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions) by Microsoft
- `Naming conventions:` for our naming conventions we decided on using [C# identifier naming rules and conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names) by Microsoft

## Repository Management

For managing our project repositories we will be using the rolling release forking workflow. This means there will be one main branch that every developer will fork from, after which the developer is expected to manage their own fork. This means the developer needs to keep their fork on par with the upstream repository by regularly pulling changes from the main branch and resolving any conflicts that may arise. 

When finishing a feature or bug fix, the developer should create a pull request to the main branch. The pull request will be reviewed by the designated reviewer(s) (in most cases the designated code lead) and merged into the main branch if approved. 

> To review the pull request, the reviewer should follow the designated definition of done of the issue(s) that the pull request is addressing.

This way the main will always be a stable version of the project and the developers can work on their own pace without interfering with the work of others.

### Task Template

For managing our coding tasks we will be using the following template:

```markdown
# Feature: Cannon

## Description

A cannon is a game object which shoots projectiles in a specific direction.

## Functional Requirements

- [ ] It should be able to translate a float variable into a rotation around it's origin
- [ ] It should be able to shoot a projectile 

## Acceptance Criteria

- [ ] It should use multiple scripts for its functional behaviour to allow for reusability
- [ ] It should use object pooling for managing it's projectiles

## Dependencies

None

## Definition of Done

- [ ] Follows KISS&EF
- [ ] Follows the naming conventions
- [ ] Follows the coding conventions
- [ ] Acceptance criteria have been met
- [ ] Pull request has been opened
```

### Pull Request Template

Our pull requests will follow the following template:

```markdown
# Pull Request: Cannon

## Related Issues

- Feature: Cannon #1

## Summary of Changes

Implements the cannon feature as described per the game design document and technical requirements analysis.

## Additional Remarks

There seems to be a problem when trying to change the projectile object type from the inspector, could someone look over this before merging?

## Pull Criteria

- [ ] Code commits have been reviewed
- [ ] Changes have been made if requested
```

## Sources

The information outlined in the document was discussed and agreed upon during:
- The code meeting of 19-04-24
- The code meeting of 25-04-24