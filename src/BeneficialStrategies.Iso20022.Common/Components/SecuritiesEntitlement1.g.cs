﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesEntitlement1.  ISO2002 ID# _UJRgh9p-Ed-ak6NoX_4Aeg_1912782907.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides entitlement information.
/// </summary>
public partial record SecuritiesEntitlement1
     : IIsoXmlSerilizable<SecuritiesEntitlement1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    public required UnitOrFaceAmount1Choice_ EntitledSecuritiesQuantity { get; init; } 
    
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
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        SecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "EntitldSctiesQty", xmlNamespace );
        EntitledSecuritiesQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SecuritiesEntitlement1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
