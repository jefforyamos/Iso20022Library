﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AvailableFinancialResourcesAmount1.  ISO2002 ID# _cu3rILV3EeeKi_hRJkOpmQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Construct used by a central counterparty to define the size of the aggregate quantum of resources available from a clearing member.
/// </summary>
public partial record AvailableFinancialResourcesAmount1
     : IIsoXmlSerilizable<AvailableFinancialResourcesAmount1>
{
    #nullable enable
    
    /// <summary>
    /// Total value of the initial margin (IM) requirement for all members at the last business day of the month.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TotalInitialMargin { get; init; } 
    /// <summary>
    /// Total value of the clearing member pre-funded default fund, excluding pre-funded contributions to the default fund from the CCP.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TotalPrefundedDefaultFund { get; init; } 
    /// <summary>
    /// Value of the CCP’s own contribution to the default waterfall junior to the pre-funded default fund contributions of the non-defaulting clearing members.
    /// </summary>
    public ReportingAssetBreakdown1? CCPSkinInTheGame { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _WGvdAK_uEeaE9YROwd69hA
    /// <summary>
    /// Total value of other contributions to the pre-funded default fund, not received from clearing members, including any contribution from the CCP that is pari-passu with the default fund contributions of the non-defaulting clearing members.
    /// </summary>
    public required IsoActiveCurrencyAndAmount OtherDefaultFundContribution { get; init; } 
    /// <summary>
    /// Total value of all legally‐bound commitments for members to provide additional resources to available to mutualise losses on exhaustion of the default fund.
    /// </summary>
    public required IsoActiveCurrencyAndAmount UnfundedMemberCommitment { get; init; } 
    /// <summary>
    /// Total value of any third‐party commitments to provide additional resources to absorb losses, for example, from insurers.
    /// </summary>
    public required IsoActiveCurrencyAndAmount UnfundedThirdPartyCommitment { get; init; } 
    
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
        writer.WriteStartElement(null, "TtlInitlMrgn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalInitialMargin)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlPrfnddDfltFnd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalPrefundedDefaultFund)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        // Not sure how to serialize CCPSkinInTheGame, multiplicity Unknown
        writer.WriteStartElement(null, "OthrDfltFndCntrbtn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(OtherDefaultFundContribution)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UfnddMmbCmmtmnt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(UnfundedMemberCommitment)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UfnddThrdPtyCmmtmnt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(UnfundedThirdPartyCommitment)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static AvailableFinancialResourcesAmount1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
