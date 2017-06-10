# Strategy & Command Patterns

A look at the use of the strategy & command patterns (including the template pattern due to it's similarity to the strategy).

## Template

Where a generic body body of work needs to be carried out, we can generalise the main body into a template as an abstract class which can then be implemented by the downstream classes.

*See the abstract class in ReaderTemplate.cs and the inheriting classes in FileReader.cs & UrlReader.cs*

## Strategy

The strategy pattern solves the same problem by an inversion of dependencies. The class that calls the methods that carry out the actual work depends on an interface which is implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies. These can then be used in calls to the constructoris implemented as the various strategies.

*See the interface in IReader.cs, the implementations in FileReader.cs & UrlReader.cs and the runner in Deployment.cs*

## Command

The command pattern is simple and focuses on one method defined in an interface. This simplicity allows for a lot of potential uses, such as a pipeline of processes, maintaining a multi-level command/undo state or developing an active state engine (to mention but a few).

*See the interface in ICommand.cs, the implementations in AddTwo.cs, DivideByThree.cs and MultiplyByFive.cs and the pipeline runner in Pipeline.cs*