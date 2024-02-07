﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionMovementFailedStatus1.  ISO2002 ID# _Rjbfptp-Ed-ak6NoX_4Aeg_-659137401.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the failure of the settlement of a movement.
/// </summary>
public partial record CorporateActionMovementFailedStatus1
     : IIsoXmlSerilizable<CorporateActionMovementFailedStatus1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the agent account.
    /// </summary>
    public required IsoMax35Text AgentAccountIdentification { get; init; } 
    /// <summary>
    /// Identification of the client account.
    /// </summary>
    public IsoMax35Text? ClientAccountIdentification { get; init; } 
    /// <summary>
    /// Identification of the party that owns the client account.
    /// </summary>
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    /// <summary>
    /// Provides information about the resource movement that failed and the reason of the failure.
    /// </summary>
    public FailedMovement1? ResourceDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Rjbfqtp-Ed-ak6NoX_4Aeg_-1713973917
    
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
        writer.WriteStartElement(null, "AgtAcctId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(AgentAccountIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ClientAccountIdentification is IsoMax35Text ClientAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntAcctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientAccountIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwnerIdentification is PartyIdentification2Choice_ AccountOwnerIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctOwnrId", xmlNamespace );
            AccountOwnerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize ResourceDetails, multiplicity Unknown
    }
    public static CorporateActionMovementFailedStatus1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
