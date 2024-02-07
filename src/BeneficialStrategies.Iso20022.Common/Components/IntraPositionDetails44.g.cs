﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails44.  ISO2002 ID# _ZcRuHZwxEeazcsnODTksnQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails44
     : IIsoXmlSerilizable<IntraPositionDetails44>
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat17Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    public required SecuritiesBalanceType8Choice_ BalanceFrom { get; init; } 
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    public IntraPositionMovementDetails14? IntraPositionMovement { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _ZcRuJZwxEeazcsnODTksnQ
    
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
        if (SafekeepingPlace is SafekeepingPlaceFormat17Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BalFr", xmlNamespace );
        BalanceFrom.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize IntraPositionMovement, multiplicity Unknown
    }
    public static IntraPositionDetails44 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
