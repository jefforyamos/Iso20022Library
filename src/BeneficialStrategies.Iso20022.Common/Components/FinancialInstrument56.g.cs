﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument56.  ISO2002 ID# _O85HgU_dEeaB8-OWTiMVrQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
public partial record FinancialInstrument56
     : IIsoXmlSerilizable<FinancialInstrument56>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the security by an ISIN.
    /// </summary>
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Additional information about the financial instrument to help identify the instrument.
    /// </summary>
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    /// <summary>
    /// Features of units offered by the fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, 'Class A', 'Class 2'.
    /// </summary>
    public IsoMax35Text? ClassType { get; init; } 
    /// <summary>
    /// Form of ownership, that is registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Income policy relating to the class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    public IsoMax140Text? ProductGroup { get; init; } 
    /// <summary>
    /// When an account at fund or security level is blocked, this specifies details on how the holding is blocked.
    /// </summary>
    public BlockedHoldingDetails2? BlockedHoldingDetails { get; init; } 
    /// <summary>
    /// Specifies whether the holdings in the account are eligible for pledging.
    /// </summary>
    public Eligible1Code? Pledging { get; init; } 
    /// <summary>
    /// Specifies whether the holdings in the account are used as collateral.
    /// </summary>
    public Collateral1Code? Collateral { get; init; } 
    /// <summary>
    /// Details of third party rights.
    /// </summary>
    public ThirdPartyRights1? ThirdPartyRights { get; init; } 
    /// <summary>
    /// Specifies if all the shares are owned exclusively by the fund company.
    /// </summary>
    public FundOwnership1Code? FundOwnership { get; init; } 
    /// <summary>
    /// Specifies if the fund is intended for qualified investors.
    /// </summary>
    public FundIntention1Code? FundIntention { get; init; } 
    /// <summary>
    /// Operational status of the fund.
    /// </summary>
    public OperationalStatus1Code? OperationalStatus { get; init; } 
    
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
        if (Name is IsoMax350Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (ShortName is IsoMax35Text ShortNameValue)
        {
            writer.WriteStartElement(null, "ShrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ShortNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SupplementaryIdentification is IsoMax35Text SupplementaryIdentificationValue)
        {
            writer.WriteStartElement(null, "SplmtryId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SupplementaryIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClassType is IsoMax35Text ClassTypeValue)
        {
            writer.WriteStartElement(null, "ClssTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClassTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SecuritiesForm is FormOfSecurity1Code SecuritiesFormValue)
        {
            writer.WriteStartElement(null, "SctiesForm", xmlNamespace );
            writer.WriteValue(SecuritiesFormValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DistributionPolicy is DistributionPolicy1Code DistributionPolicyValue)
        {
            writer.WriteStartElement(null, "DstrbtnPlcy", xmlNamespace );
            writer.WriteValue(DistributionPolicyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ProductGroup is IsoMax140Text ProductGroupValue)
        {
            writer.WriteStartElement(null, "PdctGrp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ProductGroupValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (BlockedHoldingDetails is BlockedHoldingDetails2 BlockedHoldingDetailsValue)
        {
            writer.WriteStartElement(null, "BlckdHldgDtls", xmlNamespace );
            BlockedHoldingDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Pledging is Eligible1Code PledgingValue)
        {
            writer.WriteStartElement(null, "Pldgg", xmlNamespace );
            writer.WriteValue(PledgingValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Collateral is Collateral1Code CollateralValue)
        {
            writer.WriteStartElement(null, "Coll", xmlNamespace );
            writer.WriteValue(CollateralValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ThirdPartyRights is ThirdPartyRights1 ThirdPartyRightsValue)
        {
            writer.WriteStartElement(null, "ThrdPtyRghts", xmlNamespace );
            ThirdPartyRightsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FundOwnership is FundOwnership1Code FundOwnershipValue)
        {
            writer.WriteStartElement(null, "FndOwnrsh", xmlNamespace );
            writer.WriteValue(FundOwnershipValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (FundIntention is FundIntention1Code FundIntentionValue)
        {
            writer.WriteStartElement(null, "FndIntntn", xmlNamespace );
            writer.WriteValue(FundIntentionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OperationalStatus is OperationalStatus1Code OperationalStatusValue)
        {
            writer.WriteStartElement(null, "OprlSts", xmlNamespace );
            writer.WriteValue(OperationalStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrument56 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
