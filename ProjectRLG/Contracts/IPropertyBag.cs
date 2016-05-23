﻿namespace ProjectRLG.Contracts
{
    using System.Collections.Generic;

    public interface IPropertyBag
    {
        string this[string key] { get; set; }
        string GetProperty(string key);
        bool GetPropertyAsBool(string key);
        void SetProperty(string key, string value);
    }
}
