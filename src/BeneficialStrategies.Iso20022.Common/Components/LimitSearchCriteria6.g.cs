﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitSearchCriteria6.  ISO2002 ID# _FZ5lXW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a limit.
/// </summary>
public partial record LimitSearchCriteria6
     : IIsoXmlSerilizable<LimitSearchCriteria6>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a member within a system, assigned using the member identification scheme of the system.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; init; } 
    /// <summary>
    /// Type of limit as set by default in the system. The default limit is applicable by the system unless otherwise instructed.
    /// </summary>
    public LimitType1Choice_? DefaultLimitType { get; init; } 
    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    public LimitType1Choice_? CurrentLimitType { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    /// <summary>
    /// Actual usage of the limit expressed as an amount.
    /// </summary>
    public ActiveAmountRange3Choice_? UsedAmount { get; init; } 
    /// <summary>
    /// Actual usage of the limit expressed as a percentage.
    /// </summary>
    public PercentageRange1Choice_? UsedPercentage { get; init; } 
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    public ActiveAmountRange3Choice_? LimitAmount { get; init; } 
    /// <summary>
    /// Range of dates when the limit becomes valid.
    /// </summary>
    public DateAndPeriod2Choice_? LimitValidAsOfDate { get; init; } 
    
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
        if (SystemIdentification is SystemIdentification2Choice_ SystemIdentificationValue)
        {
            writer.WriteStartElement(null, "SysId", xmlNamespace );
            SystemIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BilateralLimitCounterpartyIdentification is BranchAndFinancialInstitutionIdentification6 BilateralLimitCounterpartyIdentificationValue)
        {
            writer.WriteStartElement(null, "BilLmtCtrPtyId", xmlNamespace );
            BilateralLimitCounterpartyIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DefaultLimitType is LimitType1Choice_ DefaultLimitTypeValue)
        {
            writer.WriteStartElement(null, "DfltLmtTp", xmlNamespace );
            DefaultLimitTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrentLimitType is LimitType1Choice_ CurrentLimitTypeValue)
        {
            writer.WriteStartElement(null, "CurLmtTp", xmlNamespace );
            CurrentLimitTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountOwner is BranchAndFinancialInstitutionIdentification6 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountIdentification is AccountIdentification4Choice_ AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            AccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UsedAmount is ActiveAmountRange3Choice_ UsedAmountValue)
        {
            writer.WriteStartElement(null, "UsdAmt", xmlNamespace );
            UsedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UsedPercentage is PercentageRange1Choice_ UsedPercentageValue)
        {
            writer.WriteStartElement(null, "UsdPctg", xmlNamespace );
            UsedPercentageValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LimitCurrency is ActiveCurrencyCode LimitCurrencyValue)
        {
            writer.WriteStartElement(null, "LmtCcy", xmlNamespace );
            writer.WriteValue(LimitCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (LimitAmount is ActiveAmountRange3Choice_ LimitAmountValue)
        {
            writer.WriteStartElement(null, "LmtAmt", xmlNamespace );
            LimitAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LimitValidAsOfDate is DateAndPeriod2Choice_ LimitValidAsOfDateValue)
        {
            writer.WriteStartElement(null, "LmtVldAsOfDt", xmlNamespace );
            LimitValidAsOfDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static LimitSearchCriteria6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
