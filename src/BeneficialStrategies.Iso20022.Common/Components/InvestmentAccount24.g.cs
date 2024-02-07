﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount24.  ISO2002 ID# _Rw1ph9p-Ed-ak6NoX_4Aeg_-1507060862.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
public partial record InvestmentAccount24
     : IIsoXmlSerilizable<InvestmentAccount24>
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification2Choice_? OwnerIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification1? AccountIdentification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? AccountName { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    public IsoMax35Text? AccountDesignation { get; init; } 
    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    public Intermediary10? IntermediaryInformation { get; init; } 
    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Indicates whether a security exists only as an electronic record, ie, there is no physical document representing the security.
    /// </summary>
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    /// <summary>
    /// Party related to an account that is not the legal account owner, eg, the power of attorney.
    /// </summary>
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public SubAccount1? SubAccountDetails { get; init; } 
    
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
        if (OwnerIdentification is PartyIdentification2Choice_ OwnerIdentificationValue)
        {
            writer.WriteStartElement(null, "OwnrId", xmlNamespace );
            OwnerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountIdentification is AccountIdentification1 AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            AccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountName is IsoMax35Text AccountNameValue)
        {
            writer.WriteStartElement(null, "AcctNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountDesignation is IsoMax35Text AccountDesignationValue)
        {
            writer.WriteStartElement(null, "AcctDsgnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountDesignationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (IntermediaryInformation is Intermediary10 IntermediaryInformationValue)
        {
            writer.WriteStartElement(null, "IntrmyInf", xmlNamespace );
            IntermediaryInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesForm is FormOfSecurity1Code SecuritiesFormValue)
        {
            writer.WriteStartElement(null, "SctiesForm", xmlNamespace );
            writer.WriteValue(SecuritiesFormValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DematerialisedIndicator is IsoYesNoIndicator DematerialisedIndicatorValue)
        {
            writer.WriteStartElement(null, "DmtrlsdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(DematerialisedIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (IncomePreference is IncomePreference1Code IncomePreferenceValue)
        {
            writer.WriteStartElement(null, "IncmPref", xmlNamespace );
            writer.WriteValue(IncomePreferenceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BeneficiaryCertificationCompletion is BeneficiaryCertificationCompletion1Code BeneficiaryCertificationCompletionValue)
        {
            writer.WriteStartElement(null, "BnfcryCertfctnCmpltn", xmlNamespace );
            writer.WriteValue(BeneficiaryCertificationCompletionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AccountServicer is PartyIdentification2Choice_ AccountServicerValue)
        {
            writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
            AccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubAccountDetails is SubAccount1 SubAccountDetailsValue)
        {
            writer.WriteStartElement(null, "SubAcctDtls", xmlNamespace );
            SubAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvestmentAccount24 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
