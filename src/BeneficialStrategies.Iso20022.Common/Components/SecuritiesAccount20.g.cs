﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccount20.  ISO2002 ID# _AUpPwNokEeC60axPepSq7g_151195730.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number assigned by a government agency to identify foreign nationals.
/// </summary>
public partial record SecuritiesAccount20
     : IIsoXmlSerilizable<SecuritiesAccount20>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Choice between a code and a data source scheme to identify the type of account.
    /// </summary>
    public required ClearingAccountType1Code Type { get; init; } 
    /// <summary>
    /// .
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static SecuritiesAccount20 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
