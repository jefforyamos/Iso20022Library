﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ISA.  ISO2002 ID# _1AA5AbNBEeewUI7-Tnew9A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio4Choice;

/// <summary>
/// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. 
/// The Individual Savings Account (ISA) is provided only by UK based financial institutions.
/// </summary>
public partial record ISA : ISAPortfolio4Choice_
     , IIsoXmlSerilizable<ISA>
{
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    public CurrentYearType2Choice_? CurrentYear { get; init; } 
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    public PreviousYear2Choice_? PreviousYears { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CurrentYear is CurrentYearType2Choice_ CurrentYearValue)
        {
            writer.WriteStartElement(null, "CurYr", xmlNamespace );
            CurrentYearValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousYears is PreviousYear2Choice_ PreviousYearsValue)
        {
            writer.WriteStartElement(null, "PrvsYrs", xmlNamespace );
            PreviousYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new ISA Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
