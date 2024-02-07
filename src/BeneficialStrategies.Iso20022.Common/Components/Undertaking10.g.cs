﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Undertaking10.  ISO2002 ID# _VAaxMH7pEeGudZE4UaJCHQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details related to the undertaking.
/// </summary>
public partial record Undertaking10
     : IIsoXmlSerilizable<Undertaking10>
{
    #nullable enable
    
    /// <summary>
    /// Details related to the requested new amount for the counter-undertaking.
    /// </summary>
    public UndertakingAmount2? NewUndertakingAmount { get; init; } 
    /// <summary>
    /// Details related to the requested new expiry terms for the counter-undertaking.
    /// </summary>
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    
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
        if (NewUndertakingAmount is UndertakingAmount2 NewUndertakingAmountValue)
        {
            writer.WriteStartElement(null, "NewUdrtkgAmt", xmlNamespace );
            NewUndertakingAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewExpiryDetails is ExpiryDetails1 NewExpiryDetailsValue)
        {
            writer.WriteStartElement(null, "NewXpryDtls", xmlNamespace );
            NewExpiryDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Undertaking10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
