using System;

public class Result
{
    private bool _status;
    private string _errorMessage;

    public Result(bool status)
    {
        _status = status;
    }

    public Result(bool status, string messege)
    {
        _status = status;
        _errorMessage = messege;
    }

    public bool Status
    {
        get { return _status; }
    }
}