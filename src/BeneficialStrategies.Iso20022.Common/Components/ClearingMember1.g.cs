﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingMember1.  ISO2002 ID# _l_0jkJXZEeaEh9L5Y0ZaKQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Legal counterpart to trades cleared through a central counterparty.
/// </summary>
public partial record ClearingMember1
     : IIsoXmlSerilizable<ClearingMember1>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the clearing member.
    /// </summary>
    public required PartyIdentification118Choice_ Identification { get; init; } 
    /// <summary>
    /// Credit quality for the clearing member.
    /// </summary>
    public required CreditQuality1Code CreditQuality { get; init; } 
    /// <summary>
    /// Identification of the ultimate parent of a clearing member if it is not the parent company itself.
    /// </summary>
    public PartyIdentification118Choice_? UltimateParentIdentification { get; init; } 
    /// <summary>
    /// Identifies whether the clearing member is registered under the Commodity Exchange Act.
    /// </summary>
    public required IsoTrueFalseIndicator FuturesCommissionMerchantIndicator { get; init; } 
    /// <summary>
    /// Date on which the entity becomes a clearing member contractually subject to the CCP’s Rulebook.
    /// </summary>
    public required IsoISODate MembershipValidFrom { get; init; } 
    /// <summary>
    /// Date on which the clearing member is no longer a member in any clearing services protected by the default waterfall as defined by the CCP’s rules. Typically this will be the day the clearing member’s default fund contribution is repaid or they are no longer contractually subject to rights of assessment.
    /// </summary>
    public IsoISODate? MembershipValidTo { get; init; } 
    /// <summary>
    /// Identification of another clearing member or institution that acts as sponsor to the clearing member, undertaking certain of its obligations at the central counterparty on its behalf. These obligations typically include, but are not limited to, making default fund contributions and participating in default auctions.
    /// </summary>
    public PartyIdentification118Choice_? SponsoringClearingMemberIdentification { get; init; } 
    /// <summary>
    /// Operational construct of a central counterparty that defines the relationship between collateral, margin and position accounts and upon default of a clearing member defines the segregation of losses on positions and assets held in that account.
    /// </summary>
    public ClearingAccount1? ClearingAccountOwner { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is __bi88KclEeaGcf8_qtd8Yw
    
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
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtQlty", xmlNamespace );
        writer.WriteValue(CreditQuality.ToString()); // Enum value
        writer.WriteEndElement();
        if (UltimateParentIdentification is PartyIdentification118Choice_ UltimateParentIdentificationValue)
        {
            writer.WriteStartElement(null, "UltmtPrntId", xmlNamespace );
            UltimateParentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "FutrsComssnMrchntInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(FuturesCommissionMerchantIndicator)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MmbshVldFr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(MembershipValidFrom)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (MembershipValidTo is IsoISODate MembershipValidToValue)
        {
            writer.WriteStartElement(null, "MmbshVldTo", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MembershipValidToValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SponsoringClearingMemberIdentification is PartyIdentification118Choice_ SponsoringClearingMemberIdentificationValue)
        {
            writer.WriteStartElement(null, "SpnsrgClrMmbId", xmlNamespace );
            SponsoringClearingMemberIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize ClearingAccountOwner, multiplicity Unknown
    }
    public static ClearingMember1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
