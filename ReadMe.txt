All of the logging frameworks included in this solution are configured using config files.  Each framework has the capability to be 
configured programattically.  I intend on updating each of them with an example of this capability.  Each framework example
demonstrates logging to the console, text file and event log.  I intend on updating each of them to include logging to a
database example.

Each framework has the ability to log messages syncronously or asyncronously.  Each example demonstrates the asyncronous method.
Each framework has the capacity to log internal errors that occur in the logging assembly.

Each framework has the capability to route logging messages to an email service.  I intend on updating each framework with this 
capability.

=========================================================================================================================================
So configuration of Log4Net seems to me a bit more comp[licated than Nlog.  Log4Net uses clasic threading techniques to accomplish
asyncronous logging as opposed to just adding a config file entry with Nlog.

Enterprise Library Logging is a bit more complex than the other logging frameworks.  First, logging and exception logging are seperated 
into two seperate assemblies.  Logging exceptions requires you to configure the exception logging assembly and implement implement the exception
handling block.  Additionaly, if you plan to log entries to a database you need to install and configure the 
EnterpriseLibrary.Logging.Database assembly.
