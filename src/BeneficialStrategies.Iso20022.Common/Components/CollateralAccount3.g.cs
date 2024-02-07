﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralAccount3.  ISO2002 ID# _o2WOMa_XEeaiqo1qOdNaWg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information on the collateral account of the party delivering/receiving the collateral.
/// </summary>
public partial record CollateralAccount3
     : IIsoXmlSerilizable<CollateralAccount3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the collateral account.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Indicates the type of collateral account.
    /// </summary>
    public CollateralAccountIdentificationType3Choice_? Type { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
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
        if (Type is CollateralAccountIdentificationType3Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static CollateralAccount3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
