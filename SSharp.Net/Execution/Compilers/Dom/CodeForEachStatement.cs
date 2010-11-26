﻿namespace Scripting.SSharp.Execution.Compilers.Dom
{
  internal class CodeForEachStatement : CodeStatement
  {
    public CodeExpression Container
    {
      get;
      private set;
    }

    public CodeVariableReference Id
    {
      get;
      private set;
    }

    public CodeStatement Statement
    {
      get;
      private set;
    }

    public CodeForEachStatement(CodeVariableReference id, CodeExpression container, CodeStatement statement)
    {
      Container = container;
      Id = id;
      Statement = statement;
    }
  }

}