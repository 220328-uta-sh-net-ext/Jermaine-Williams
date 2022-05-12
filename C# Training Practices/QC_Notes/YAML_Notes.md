# YAML - Yet Another Markup Langauge/YAML Ain't Markup Language

## What is YAML?

- YAML is serialized markup langauge, similar to XML or JSON.
- It's often commonly used to format or serialize configuation files, just like XML or JSON
- It uses a Python-like style for it's format and syntax.

![](https://cdn.ttgtmedia.com/rms/onlineImages/itops-yaml_code_7_mobile.png)

- Example of how object data that is serialzed in YAML format looks like.

## Why Do We Use YAML?

- As stated before, it can be used another way to serialze object data from one IDE to a database in place of XML or JSON since it's much more easier to read and learn.
- However it's used more in a pipeline for application deployment through DevOps.

![](https://www.dotnetcurry.com/images/devops/yaml-cicd/image-4.png?w=321&h=218)

- Basic syntax/schema for using YAML in a Build Pipeline

## Pipleine Keywords

- Triggers are used to determine when to activate the pipeline.
  - There can be diffent kinds of ways to trigger your pipeline into activating. You can trigger it to run every time there a pull request to your repo, every time Continuous Intergration is involved whenever an update it pushed to certain branches, you can schedule it to run at midnight every day, or you can even activate it manually by typing <ins>none</ins> after the trigger keyword.

- Stages are use to organise jobs in a pipeline. Each stage can have one or more jobs. You can have stages depend on one another and run if they have ran or have each stage have a condition to run if the previous stages have their run's sucucceded.

- Jobs are a collection of one or more steps, every pipeline has at least one job. It's also the smallest unit of work that can be scheduled to run. Like stages, they can depend on things to run and can have contitions.
  - There are three types of jobs:
    - Agent Pool Jobs: ran on an agent, or an agent pool
    - Server Jobs: ran on Azure DevOps server
    - Container Jobs: ran in a container or an agent

    Each job inside an Azure Pipeline is ran on an agent.

- Agents are softwares that can run one job at a time
  - There are two kinds of Agents:
    - Self-Hosted: owned and managed by you or the client. It gives you more control to install dependant packages or build and deployments.
    - Microsoft Hosted: Microsoft provides a new VM (Virtual Machine) every time a job needs to run. Maintenance and upgrades on the VM would be managed by Microsoft.

- Tasks are the actual execution unit within a pipeline. A job can have more than one task. You define that work you want to do in your pipeline. Azure DevOps comes prebuilt with a plethora of options for what you would like to do for your task in your pipeline.

- Approvals are a feature along with Gates to control the workflow of the app's deployment pipeline. Each stage within the pipline's release can be configured with either a pre-deployment or post-deployment conditions that depend on the scenario that you might run into.
  - For example, you'd might want to use the Pre-Deployment feaure if a user has to manually validate a change request and approve the deployment to a certain stage.
  - Or you might want to use the Post-Deployment feature if a team wants to ensure there are no incidents that were reported after their app's deployment, before triggering a release for it.
- By using approvals, along with gates, and manual intervention you can take full control of your releases to meet a wide range of deployment requirements.
