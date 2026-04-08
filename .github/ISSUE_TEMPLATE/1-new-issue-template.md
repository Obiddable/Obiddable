name: "📄 New Issue"
description: "Create a new issue with structured fields."
title: "[{{category}}/{{priority}}] : {{title}}"
labels: ''
assignees: 
  - Tiptup300
body:
  - type: input
    id: title
    attributes:
      label: Title
      description: Brief summary of the issue
      placeholder: "Short descriptive title"
      required: true

  - type: textarea
    id: description
    attributes:
      label: Description
      description: Full details of the issue
      placeholder: "Provide a detailed description of the issue"
      required: true

  - type: dropdown
    id: category
    attributes:
      label: Category
      description: "Select the category of the issue"
      options:
        - UX
        - Infra
        - Typo
        - Pipeline
        - DevEx
        - Rework
        - Bug
        - Improvement
      required: true

  - type: dropdown
    id: priority
    attributes:
      label: Priority
      description: "Select the priority level of this issue"
      options:
        - Low
        - Medium
        - High
      required: true

  - type: textarea
    id: acceptance_criteria
    attributes:
      label: Acceptance Criteria
      description: "Define testable criteria for this issue"
      placeholder: |
        ```gherkin
        # AC-1: <Clear and testable capability>
        # AC-2: <Second capability or behavioral grouping>
        ```
      required: true