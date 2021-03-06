﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Testing.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Service")]
    public partial class ServiceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Service.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Service", "The Service process all \r\nInvoice for clients and actualize \r\nthe Invoice with th" +
                    "e approval", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Process Invoice for Client")]
        [NUnit.Framework.CategoryAttribute("process")]
        public virtual void ProcessInvoiceForClient()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Process Invoice for Client", new string[] {
                        "process"});
#line 7
 this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name"});
            table1.AddRow(new string[] {
                        "1",
                        "Client 1"});
            table1.AddRow(new string[] {
                        "2",
                        "Client 2"});
            table1.AddRow(new string[] {
                        "3",
                        "Client 3"});
#line 8
 testRunner.Given("a group of the clients", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Value"});
            table2.AddRow(new string[] {
                        "1",
                        "Invoice 1",
                        "128"});
            table2.AddRow(new string[] {
                        "2",
                        "Invoice 2",
                        "568.45"});
#line 13
 testRunner.And("a Group of Invoice for  client (1)", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "3",
                        "Invoice 3",
                        "684"});
#line 17
 testRunner.And("a Group of Invoice for  client (2)", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Value"});
            table4.AddRow(new string[] {
                        "4",
                        "Invoice 4",
                        "995"});
#line 20
 testRunner.And("a Group of Invoice for  client (3)", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Step",
                        "Role"});
            table5.AddRow(new string[] {
                        "Rule 1",
                        "Less 500",
                        "Automatic Approver"});
#line 23
 testRunner.And("a Rule for Invoice (1)", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Step",
                        "Role"});
            table6.AddRow(new string[] {
                        "Rule 1",
                        "Less 500",
                        "Automatic Approver"});
#line 26
 testRunner.And("a Rule for Invoice (2)", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Step",
                        "Role"});
            table7.AddRow(new string[] {
                        "Rule 2",
                        "More 501 And Less 1000",
                        "Automatic Approve"});
#line 29
 testRunner.And("a Rule for Invoice (3)", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Step",
                        "Role"});
            table8.AddRow(new string[] {
                        "Rule 2",
                        "More 501 And Less 1000",
                        "Automatic Approve"});
#line 32
 testRunner.And("a Rule for Invoice (4)", ((string)(null)), table8, "And ");
#line 35
 testRunner.When("Invoice Process Run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("Verified Client Get Method is Called", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And("Verified the Invoice Method is Called For Client (1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("Verified the Invoice Method is Called For Client (2)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("Verified the Invoice Method is Called For Client (3)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("for every invoice the Chain Method is Called four times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("The Method Save is Called four times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
