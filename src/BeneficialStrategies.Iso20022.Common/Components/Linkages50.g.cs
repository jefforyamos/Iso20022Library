﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages50.  ISO2002 ID# _dsRUYb-CEeW_u_CSZtGM1g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
public partial record Linkages50
     : IIsoXmlSerilizable<Linkages50>
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction - for information only.
    /// </summary>
    public ProcessingPosition23Choice_? ProcessingPosition { get; init; } 
    /// <summary>
    /// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    public required IsoRestrictedFINXMax16Text SecuritiesSettlementTransactionIdentification { get; init; } 
    
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
        if (ProcessingPosition is ProcessingPosition23Choice_ ProcessingPositionValue)
        {
            writer.WriteStartElement(null, "PrcgPos", xmlNamespace );
            ProcessingPositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesSttlmTxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(SecuritiesSettlementTransactionIdentification)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
    }
    public static Linkages50 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
