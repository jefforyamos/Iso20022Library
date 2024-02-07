﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ForAllAccounts.  ISO2002 ID# _VJ1ncyLLEeyNSNrMl2zWxg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification49Choice;

/// <summary>
/// All safekeeping accounts that own underlying financial instrument.
/// </summary>
public partial record ForAllAccounts : AccountIdentification49Choice_
     , IIsoXmlSerilizable<ForAllAccounts>
{
    #nullable enable
    
    /// <summary>
    /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
    /// </summary>
    public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    
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
        writer.WriteStartElement(null, "IdCd", xmlNamespace );
        writer.WriteValue(IdentificationCode.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new ForAllAccounts Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
