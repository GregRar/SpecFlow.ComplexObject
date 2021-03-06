﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.ComplexObject.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateComplexInstance")]
    public partial class CreateComplexInstanceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateComplexInstance.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateComplexInstance", "\tIn order to avoid code duplication for mapping between table and  complex object" +
                    "s \r\n\tAs a test enigneer\r\n\tI want extenstion to map values from the table into ob" +
                    "ject", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Map all simple data types from table using CreateComplexIntance extension")]
        public virtual void MapAllSimpleDataTypesFromTableUsingCreateComplexIntanceExtension()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Map all simple data types from table using CreateComplexIntance extension", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("Sample complex class with initialized properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "property",
                        "value"});
            table1.AddRow(new string[] {
                        "StringValue",
                        "String property value"});
            table1.AddRow(new string[] {
                        "StringEmpty",
                        "<empty>"});
            table1.AddRow(new string[] {
                        "StringNull",
                        "<null>"});
            table1.AddRow(new string[] {
                        "IntValue",
                        "5"});
            table1.AddRow(new string[] {
                        "IntNullableValue",
                        "10"});
            table1.AddRow(new string[] {
                        "IntNullableNull",
                        "<null>"});
            table1.AddRow(new string[] {
                        "DecimalValue",
                        "2.3"});
            table1.AddRow(new string[] {
                        "DecimalNullableValue",
                        "5.5"});
            table1.AddRow(new string[] {
                        "DecimalNullableNull",
                        "<null>"});
            table1.AddRow(new string[] {
                        "DoubleValue",
                        "1.1"});
            table1.AddRow(new string[] {
                        "DoubleNullableValue",
                        "2.2"});
            table1.AddRow(new string[] {
                        "DoubleNullableNull",
                        "<null>"});
            table1.AddRow(new string[] {
                        "FloatValue",
                        "0.6"});
            table1.AddRow(new string[] {
                        "FloatNullableValue",
                        "0.9"});
            table1.AddRow(new string[] {
                        "FloatNullableNull",
                        "<null>"});
            table1.AddRow(new string[] {
                        "GuidValue",
                        "5E302067-4354-49EE-8DAC-E50DA572A3C4"});
            table1.AddRow(new string[] {
                        "GuidNullableValue",
                        "39D75B24-5B9B-4FB6-AB82-8CBECBBDF064"});
            table1.AddRow(new string[] {
                        "GuidNullableNull",
                        "<null>"});
            table1.AddRow(new string[] {
                        "EnumValue",
                        "Yes"});
            table1.AddRow(new string[] {
                        "EnumNullableValue",
                        "No"});
            table1.AddRow(new string[] {
                        "EnumNullableNull",
                        "<null>"});
#line 8
 testRunner.When("Create instance of the same class using data from table and CreateComplexIntance " +
                    "extension", ((string)(null)), table1, "When ");
#line 44
 testRunner.Then("the objects should be the same", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
