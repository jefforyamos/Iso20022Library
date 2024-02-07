﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BankInstructions1.  ISO2002 ID# _-E96onltEeG7BsjMvd1mEw_-1962266357.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the instructions from the bank.
/// </summary>
public partial record BankInstructions1
     : IIsoXmlSerilizable<BankInstructions1>
{
    #nullable enable
    
    /// <summary>
    /// Instructions from the bank.
    /// </summary>
    public SimpleValueList<IsoMax2000Text> Text { get; init; } = [];
    /// <summary>
    /// Last date for a response to the bank instructions.
    /// </summary>
    public IsoISODate? LastDateForResponse { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Txt", xmlNamespace );
        Text.Serialize(writer, xmlNamespace, "Max2000Text", SerializationFormatter.IsoMax2000Text );
        writer.WriteEndElement();
        if (LastDateForResponse is IsoISODate LastDateForResponseValue)
        {
            writer.WriteStartElement(null, "LastDtForRspn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(LastDateForResponseValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static BankInstructions1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
