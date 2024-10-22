﻿namespace dadesignart.net.Application;

public class ErrorDto
{
  public string PropertyName { get; set; }
  public List<string> Messages { get; set; }

  public ErrorDto(string propertyName, List<string> messages)
  {
    PropertyName = propertyName;

    Messages = messages;
  }
}
