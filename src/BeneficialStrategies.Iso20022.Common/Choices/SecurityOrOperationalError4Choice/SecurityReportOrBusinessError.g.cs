﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecurityReportOrBusinessError.  ISO2002 ID# _P5yGsZJKEeuAlLVx8pyt3w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityOrOperationalError4Choice;

/// <summary>
/// Provides the financial instruments details or the business error.
/// </summary>
public partial record SecurityReportOrBusinessError : SecurityOrOperationalError4Choice_
     , IIsoXmlSerilizable<SecurityReportOrBusinessError>
{
    #nullable enable
    
    
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
    }
    public static new SecurityReportOrBusinessError Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
