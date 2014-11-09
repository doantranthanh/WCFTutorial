﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IStaffService")]
public interface IStaffService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaffService/CreateListStaff", ReplyAction="http://tempuri.org/IStaffService/CreateListStaffResponse")]
    void CreateListStaff();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaffService/DisplayStaff", ReplyAction="http://tempuri.org/IStaffService/DisplayStaffResponse")]
    string DisplayStaff();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaffService/GetBirthday", ReplyAction="http://tempuri.org/IStaffService/GetBirthdayResponse")]
    System.DateTime GetBirthday(int staffID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStaffService/GetStaffName", ReplyAction="http://tempuri.org/IStaffService/GetStaffNameResponse")]
    string GetStaffName(int staffID);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IStaffServiceChannel : IStaffService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class StaffServiceClient : System.ServiceModel.ClientBase<IStaffService>, IStaffService
{
    
    public StaffServiceClient()
    {
    }
    
    public StaffServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public StaffServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StaffServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StaffServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void CreateListStaff()
    {
        base.Channel.CreateListStaff();
    }
    
    public string DisplayStaff()
    {
        return base.Channel.DisplayStaff();
    }
    
    public System.DateTime GetBirthday(int staffID)
    {
        return base.Channel.GetBirthday(staffID);
    }
    
    public string GetStaffName(int staffID)
    {
        return base.Channel.GetStaffName(staffID);
    }
}
