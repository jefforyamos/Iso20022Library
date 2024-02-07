﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionAmounts46.  ISO2002 ID# _k9uwj83xEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
public partial record CorporateActionAmounts46
     : IIsoXmlSerilizable<CorporateActionAmounts46>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; } 
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; } 
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; } 
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    /// <summary>
    /// Local broker's commission.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Cash amount based on the terms of the corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; } 
    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; } 
    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; } 
    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; } 
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; } 
    /// <summary>
    /// Amount of proceeds which is not actually paid to the security holder but on which withholding tax is applicable.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; init; } 
    /// <summary>
    /// Amount relating to a conduit foreign income.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? ConduitForeignIncomeAmount { get; init; } 
    
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
        if (GrossCashAmount is IsoRestrictedFINActiveCurrencyAndAmount GrossCashAmountValue)
        {
            writer.WriteStartElement(null, "GrssCshAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(GrossCashAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NetCashAmount is IsoRestrictedFINActiveCurrencyAndAmount NetCashAmountValue)
        {
            writer.WriteStartElement(null, "NetCshAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(NetCashAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SolicitationFees is IsoRestrictedFINActiveCurrencyAndAmount SolicitationFeesValue)
        {
            writer.WriteStartElement(null, "SlctnFees", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(SolicitationFeesValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashInLieuOfShare is IsoRestrictedFINActiveCurrencyAndAmount CashInLieuOfShareValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(CashInLieuOfShareValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CapitalGain is IsoRestrictedFINActiveCurrencyAndAmount CapitalGainValue)
        {
            writer.WriteStartElement(null, "CptlGn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(CapitalGainValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (InterestAmount is IsoRestrictedFINActiveCurrencyAndAmount InterestAmountValue)
        {
            writer.WriteStartElement(null, "IntrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(InterestAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (MarketClaimAmount is IsoRestrictedFINActiveCurrencyAndAmount MarketClaimAmountValue)
        {
            writer.WriteStartElement(null, "MktClmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(MarketClaimAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (IndemnityAmount is IsoRestrictedFINActiveCurrencyAndAmount IndemnityAmountValue)
        {
            writer.WriteStartElement(null, "IndmntyAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(IndemnityAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ManufacturedDividendPaymentAmount is IsoRestrictedFINActiveCurrencyAndAmount ManufacturedDividendPaymentAmountValue)
        {
            writer.WriteStartElement(null, "ManfctrdDvddPmtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ManufacturedDividendPaymentAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ReinvestmentAmount is IsoRestrictedFINActiveCurrencyAndAmount ReinvestmentAmountValue)
        {
            writer.WriteStartElement(null, "RinvstmtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ReinvestmentAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FullyFrankedAmount is IsoRestrictedFINActiveCurrencyAndAmount FullyFrankedAmountValue)
        {
            writer.WriteStartElement(null, "FullyFrnkdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(FullyFrankedAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (UnfrankedAmount is IsoRestrictedFINActiveCurrencyAndAmount UnfrankedAmountValue)
        {
            writer.WriteStartElement(null, "UfrnkdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(UnfrankedAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SundryOrOtherAmount is IsoRestrictedFINActiveCurrencyAndAmount SundryOrOtherAmountValue)
        {
            writer.WriteStartElement(null, "SndryOrOthrAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(SundryOrOtherAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxFreeAmount is IsoRestrictedFINActiveCurrencyAndAmount TaxFreeAmountValue)
        {
            writer.WriteStartElement(null, "TaxFreeAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(TaxFreeAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxDeferredAmount is IsoRestrictedFINActiveCurrencyAndAmount TaxDeferredAmountValue)
        {
            writer.WriteStartElement(null, "TaxDfrrdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(TaxDeferredAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ValueAddedTaxAmount is IsoRestrictedFINActiveCurrencyAndAmount ValueAddedTaxAmountValue)
        {
            writer.WriteStartElement(null, "ValAddedTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ValueAddedTaxAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (StampDutyAmount is IsoRestrictedFINActiveCurrencyAndAmount StampDutyAmountValue)
        {
            writer.WriteStartElement(null, "StmpDtyAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(StampDutyAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxReclaimAmount is IsoRestrictedFINActiveCurrencyAndAmount TaxReclaimAmountValue)
        {
            writer.WriteStartElement(null, "TaxRclmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(TaxReclaimAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxCreditAmount is IsoRestrictedFINActiveCurrencyAndAmount TaxCreditAmountValue)
        {
            writer.WriteStartElement(null, "TaxCdtAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(TaxCreditAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AdditionalTaxAmount is IsoRestrictedFINActiveCurrencyAndAmount AdditionalTaxAmountValue)
        {
            writer.WriteStartElement(null, "AddtlTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(AdditionalTaxAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (WithholdingTaxAmount is IsoRestrictedFINActiveCurrencyAndAmount WithholdingTaxAmountValue)
        {
            writer.WriteStartElement(null, "WhldgTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(WithholdingTaxAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SecondLevelTaxAmount is IsoActiveCurrencyAndAmount SecondLevelTaxAmountValue)
        {
            writer.WriteStartElement(null, "ScndLvlTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SecondLevelTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FiscalStampAmount is IsoRestrictedFINActiveCurrencyAndAmount FiscalStampAmountValue)
        {
            writer.WriteStartElement(null, "FsclStmpAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(FiscalStampAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ExecutingBrokerAmount is IsoRestrictedFINActiveCurrencyAndAmount ExecutingBrokerAmountValue)
        {
            writer.WriteStartElement(null, "ExctgBrkrAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ExecutingBrokerAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PayingAgentCommissionAmount is IsoRestrictedFINActiveCurrencyAndAmount PayingAgentCommissionAmountValue)
        {
            writer.WriteStartElement(null, "PngAgtComssnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(PayingAgentCommissionAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (LocalBrokerCommissionAmount is IsoRestrictedFINActiveCurrencyAndAmount LocalBrokerCommissionAmountValue)
        {
            writer.WriteStartElement(null, "LclBrkrComssnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(LocalBrokerCommissionAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (RegulatoryFeesAmount is IsoRestrictedFINActiveCurrencyAndAmount RegulatoryFeesAmountValue)
        {
            writer.WriteStartElement(null, "RgltryFeesAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(RegulatoryFeesAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ShippingFeesAmount is IsoRestrictedFINActiveCurrencyAndAmount ShippingFeesAmountValue)
        {
            writer.WriteStartElement(null, "ShppgFeesAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ShippingFeesAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ChargesAmount is IsoRestrictedFINActiveCurrencyAndAmount ChargesAmountValue)
        {
            writer.WriteStartElement(null, "ChrgsAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ChargesAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (EntitledAmount is IsoRestrictedFINActiveCurrencyAndAmount EntitledAmountValue)
        {
            writer.WriteStartElement(null, "EntitldAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(EntitledAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OriginalAmount is IsoRestrictedFINActiveCurrencyAndAmount OriginalAmountValue)
        {
            writer.WriteStartElement(null, "OrgnlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(OriginalAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AccruedInterestAmount is IsoRestrictedFINActiveCurrencyAndAmount AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(AccruedInterestAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (IncomePortion is IsoRestrictedFINActiveCurrencyAndAmount IncomePortionValue)
        {
            writer.WriteStartElement(null, "IncmPrtn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(IncomePortionValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (EqualisationAmount is IsoRestrictedFINActiveCurrencyAndAmount EqualisationAmountValue)
        {
            writer.WriteStartElement(null, "EqulstnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(EqualisationAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FATCATaxAmount is IsoRestrictedFINActiveCurrencyAndAmount FATCATaxAmountValue)
        {
            writer.WriteStartElement(null, "FATCATaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(FATCATaxAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NRATaxAmount is IsoRestrictedFINActiveCurrencyAndAmount NRATaxAmountValue)
        {
            writer.WriteStartElement(null, "NRATaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(NRATaxAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (BackUpWithholdingTaxAmount is IsoRestrictedFINActiveCurrencyAndAmount BackUpWithholdingTaxAmountValue)
        {
            writer.WriteStartElement(null, "BckUpWhldgTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(BackUpWithholdingTaxAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TaxOnIncomeAmount is IsoRestrictedFINActiveCurrencyAndAmount TaxOnIncomeAmountValue)
        {
            writer.WriteStartElement(null, "TaxOnIncmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(TaxOnIncomeAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TransactionTax is IsoRestrictedFINActiveCurrencyAndAmount TransactionTaxValue)
        {
            writer.WriteStartElement(null, "TxTax", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(TransactionTaxValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (DeemedAmount is IsoRestrictedFINActiveCurrencyAndAmount DeemedAmountValue)
        {
            writer.WriteStartElement(null, "DmdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(DeemedAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ConduitForeignIncomeAmount is IsoRestrictedFINActiveCurrencyAndAmount ConduitForeignIncomeAmountValue)
        {
            writer.WriteStartElement(null, "CndtFrgnIncmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(ConduitForeignIncomeAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static CorporateActionAmounts46 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
