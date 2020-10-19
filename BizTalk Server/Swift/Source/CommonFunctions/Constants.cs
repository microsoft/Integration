using System;
using System.Globalization;

namespace Microsoft.Solutions.FinancialServices.SWIFT
{
    /// <summary>
    /// Contains all the definition of all the constant strings being used by the 
    /// SWIFTCommonFunctions class.
    /// </summary>
    internal class Constants
    {	
        public	const	string	CULTURETYPE					=	"en-US";
        public	static	string	DOT							=	NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
		// Creates and initializes the CultureInfo which uses the international sort.
		public static   CultureInfo INVARIANTCULTURE		= new CultureInfo( "", false);
        public	const	string	NUMBERSET					=	"0123456789";
        public  const   string  NUMBERSETT56                =   "12345678";
        public  const   string  NUMBERSETT56_59F            =   "123";
        public  const   string  NUMBER1T56                  =   "1";
        public  const   string  NUMBERCHECKT56              =   "3567";
        public  const   string  NUMBERCHECK8T56             =   "345678";
        public  const   string  NUMBERCHECK50FT56           =   "45678";
        public  const   string  ALPHASET					=	"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public  const   string  ALPHANUMBERSET				=	"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public  const   string  LOWERALPHASET				=	"abcdefghijklmnopqrstuvwxyz";
        public  const   string  NOCONTENT					=	"Input is either null or empty";
        public  const   string	YYMMDD_DATEFORMAT			=	"YYMMDD";
        public  const   string	YYYYMMDD_DATEFORMAT			=	"YYYYMMDD";
		public  const   string	HHMM_TIMEFORMAT				=	"HHMM";
		public  const   string	HHMMSS_TIMEFORMAT			=	"HHMMSS";
        public  static  string  YEAR_LOWERBOUND_CHARS		=	"789";
        public  const   string  SWIFT_X_CHARSET				=	"1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz/-?:(),’+{} ";
        public const	string	QUALIFIER					=	"Qualifier";
	    public const	string	INDICATOR					=	"Indicator";
        public const	string	DATASOURCESCHEME			=	"DataSourceScheme";	
		public const	string	DATASOURCE			        =	"DataSource";							
        public const	string	NARRATIVE					=	"Narrative";
		public const	string	OR							=	"or";	
		public const	string	AND							=	"and";
        public const	string	SUMOFAMOUNTS				=	"Sum Of Amounts";
        public const	string	NOTPRESENT					=	"Not Present";
        public const    string  CODENOSI                    =   "/NOSI/";
        public const    string  CODESVBY                    =   "/SVBY/";
		public  const   string	CODEABIC					=	"/ABIC/";
        public const	string	CODENETS					=	"/NETS/";
        public const	string	CODESSIS					=	"/SSIS/";
        public const	string	CODECLRC					=	"/CLRC/";
        public const	string	CODESETC					=	"/SETC/";
        public const    string  CODESRCE                    			=   	"/SRCE/";
		public const	string	CODEVALD					=	"/VALD/";
        public const    string  CODEREJT                    =   "/REJT/";
        public const    string  CODERETN                    =   "/RETN/";
        public const    string  CODECHGS                    =   "/CHGS/";
        public const    string  CODETEXT                    =   "/TEXT/";
        public  const   string	STRIKE_PRICE_CURRENCY		= "StrikePriceCurrency";
        public  const   string	STRIKE_PRICE				= "StrikePrice";
        public  const   string	PREMIUM_PRICE_CURRENCY		= "PremiumPriceCurrency";
        public  const   string	PREMIUM_PRICE				= "PremiumPrice";
        public  const   string	PREMIUM_PAYMENT_CURRENCY	= "PremiumPaymentCurrency";
        public  const   string	PREMIUM_PAYMENT				= "PremiumPayment";
        public	const	string	FALSE						=   "False";
        public	const	string	TRUE						=   "True";
        public	const	string	LTDIR						=   "LTDIR";

 
        public const	string	REVCREDIT					=	"RC";
        public const	string	REVDEBIT					=	"RD";
        public const	string	DEBIT						=	"D";
        public const	string	CREDIT						=	"C";		
        public const	string	AMOUNT						=	"Amount";
        public const    string  REASONCODE                  =   "ReasonCode";
        
        public const	string	ALPHAS						=	"S";		
        public const	string	NUMBER						=	"Number";	
        public const	string	ALPHAN						=	"N";	
        public const	string	ALPHAY						=	"Y";
        public  const   string  ALPHAx					    =   "x";
        public  const   string  ALPHAn  					=   "n";
        public  const   string  ALPHAc  					=   "c";
        public  const   string  ALPHAcn                     			=   "cn";
		public  const   string  ALPHAg  					=   "3!a15d";
        public  const   string  ALPHAdate6  				=   "6!n";
        public  const   string  ALPHAd  					=   "d";
        public  const   string  ALPHAcurrency  				=   "3!a";
        public  const   string  ALPHAh  					=   "3!a15d/";
        public  const   string  ALPHAa                      =   "a";
        public  const   string  ALPHAax                      =  "ax";

		
		public  const   string  XSPECIALCHARACTERS			=	"/-?:(),’+{} ";
        public	const	string	BLANK						=	"";
        public	const	string	COMMA						=	",";
        public	const	string	DOUBLESLASH					=	"//";
        public	const	string	SLASH						=	"/";
        public	const	string  PERIOD						=   ".";
        public	const	string  SIGNNEGATIVE                =   "-";
        public	const	string  SIGNPOSITIVE                =   "+";
        public	const	string  XPATH		                =   "./";
        public	const	string  UNDERSCORE		            =   "_";
        public  const	string	HYPHEN						=	"-";
		 public  const	string	COLON						=	":";
        public const    string	XPATTERN				    = @"^[A-Za-z0-9\-\?:()\.\,'\+\{\}\s}]*$";
        public const	string  EXCLAMATION					=   "!";
        public const    string	NPATTERN				    = @"^[0-9]*$";
        public const    string	DPATTERN                    = @"^[0-9]+\,[0-9]*$";
        public const    string  CNLEICPATTERN               = @"^[A-Z0-9]{18}[0-9]{2}$"; 
        public const    string	CURRENCYPATTERN				= @"^([A-Z]{3})";
        public const    string  ALPHAaPATTERN               = @"^([A-Z]{4})";                    
		public const	string  GPATTERN					= @"([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,|([A-Z]{3})[1-9]\d{0,11}\,\d{2}|([A-Z]{3})[1-9]\d{0,12}\,\d|([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,\d{0,2}|([A-Z]{3})[1-9]\d{0,11}\,\d{2}|([A-Z]{3})[1-9]\d{0,12}\,\d|([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,\d{0,2}|([A-Z]{3})[1-9]\d{0,10}\,\d{3}|([A-Z]{3})[1-9]\d{0,11}\,\d{2}|([A-Z]{3})[1-9]\d{0,12}\,\d|([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,\d{0,3}";
		public const	string  HPATTERN					= @"((([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,|([A-Z]{3})[1-9]\d{0,11}\,\d{2}|([A-Z]{3})[1-9]\d{0,12}\,\d|([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,\d{0,2}|([A-Z]{3})[1-9]\d{0,11}\,\d{2}|([A-Z]{3})[1-9]\d{0,12}\,\d|([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,\d{0,2}|([A-Z]{3})[1-9]\d{0,10}\,\d{3}|([A-Z]{3})[1-9]\d{0,11}\,\d{2}|([A-Z]{3})[1-9]\d{0,12}\,\d|([A-Z]{3})[1-9]\d{0,13}\,|([A-Z]{3})0\,\d{0,3})/)";
        public const	string  BICPATTERN					= @"^[[A-Z]{6}[A-Z0-9]{2}]*$|^[[A-Z]{6}[A-Z0-9]{2}[A-Z0-9]{3}]*$|^[UKWN]*$";
        public const    string  CLRCPATTERN                 = @"^[[A-Z]{2}]*$|^[[A-Z]{2}[A-Za-z0-9\-\?:()\.\,'\+\{\}\s}]{0,32}]*$";
        public const    string	DATE6PATTERN				= @"^(?:0[048]|[2468][048]|[13579][26])(?:0?2(?:29))$|^(?:\d{2})(?:(?:0?[1-9]|1[0-2])(?:0?[1-9]|1\d|2[0-8]))$|^(?:\d{2})(?:(?:(?:0?[13578]|1[02])31)|(?:(?:0?[1,3-9]|1[0-2])(?:29|30)))$";
        public const    string  REASONCODEPATTERN           = @"^/X[A-Z0-9]{1}[0-9]{2}/$";
        public const    string  XPATTERN33x                 = @"^//[A-Za-z0-9/\-\?:()\.\,'\+\{\}\s}]{1,33}$";
        public const    string  LINE1FORMAT                 = @"^/[A-Z]{4}/[0-9]{2}([A-Z])?(/[A-Z0-9]{1,2})?$";
        public const    string  LINE2FORMAT                 = @"^/[A-Z0-9]{2}[0-9]{2}/([A-Za-z0-9/\-\?:()\.\,'\+\{\}\s}]{0,29})?$";
        public const    string  LINE3FORMAT                 = @"^/MREF/[A-Za-z0-9/\-\?:()\.\,'\+\{\}\s}]{1,16}$";
        public const    string  LINE4FORMAT                 = @"^/TREF/[A-Za-z0-9/\-\?:()\.\,'\+\{\}\s}]{1,16}$";
        public const    string  LINE5FORMAT                 = @"^/CHGS/[A-Z]{3}([0-9]+\,[0-9]*)$";
        public const    string  LINE6FORMAT                 = @"^/TEXT/[A-Za-z0-9/\-\?:()\.\,'\+\{\}\s}]{1,29}$";

        public	const	string	OPENSQUAREBRACKET			=	"[";
		public	const	string	CLOSESQUAREBRACKET			=	"]";
		public	const	string	SINGLEQUOTE					=	"'";
		public	const	string	EQUAL						=	"=";
		public	const	string	SPACE						=	" ";
        public	const	string	CLRCFORMAT					=	"35x";
		public	const	string	CARAT						=   "^";
        
		public const	char	CHRASTERISK					=	'*';
		public const	char	CHRSLASH					=	'/';	
        public const	char	CHRCOMMA					=	',';
        public const	char	CHRPIPE						=	'|';
        public const	char	CHRA						=	'A';		
        public const	char	CHRZ						=	'Z';	
        public const	char	CHRDOT						=   '.';
        public const	char	CHR9						=   '9';
        public const	char	CHR0						=   '0';
        public const	char	NEGATIVESIGN				=	'N'; 
        public const	char	CHRCARRIAGERETURN			=	'\r';
        public const	char	CHRLINEFEED					=	'\n';
		public	const	char	CHRCARAT					=   '^';    

        public  const   int		DATETIMELENGTH				=	14;
        public  const   int		YYMMDD_DATELENGTH			=	6;
        public  const   int		YYYYMMDD_DATELENGTH			=	8;
        public  const   int		TWENTIETHCENTURY			=	19;
        public  const   int		TWENTYFIRSTCENTURY			=	20;
        public  const   int		SWIFTYEAR_UPPERBOUND		=	9;		
        public  const   int		HHMM_TIMELENGTH				=	4;
        public  const   int		HHMMSS_TIMELENGTH			=	6;
        public  const   int		INT100						=	100;
        public  const   int		INT999						=	999;
		public  const   int		INT9999						=	9999;
        public  const   int		INT35						=	35;
        public  const   int		INT2						=	2;
        public  const   int		INT5						=	5;
        public  const   int		INT7						=	7;
        public  const   int		INT30						=	30;
        public const	int		CODELEN						=	6;
        public const	int		CLRCLEN						=	41;
        public const	int		CURRENCYSTARTPOS1			=	7;
        public const	int		CURRENCYENDPOS1			    =	3;
        public const	int		AMOUNTVALUE1		        =	10;
        public const	int		CURRENCYSTARTPOS2			=	6;
        public const	int		CURRENCYENDPOS2			    =	3;
        public const	int		AMOUNTVALUE2		        =	9;
        public const	int		YEARSTARTPOS			    =	2;
        public const	int		YEARENDPOS			        =	2;

		public const	string	MT102						=	"MT102";
		public const	string	MT102PLUS					=	"MT102PLUS";
		public const	string	MT103						=	"MT103";
		public const	string	MT103PLUS					=	"MT103PLUS";
        public const    string  MT103REMIT                  =   "MT103REMIT";
				
				
        public  const	Int16	MINLEN_STMTLINE				=	14;
        public  const   Int16	INT12						=	12;
        public  const   Int16	INT1						=	1;
        public  const   Int16	INT3						=	3;
        public  const   Int16	INT4						=	4;
        public  const	Int16   REQUESTEDMESSAGETYPE        =   535;
        public  const	Int16   INT9                        =   9;

        //Error Definitions
        public	const	string		ERRORT26				    =	"T26";
		public	const	string		ERRORT14				    =	"T14";
		public	const	string		ERRORT18				    =	"T18";
        public	const	string		ERRORT51				    =	"T51";
		public	const	string		ERRORT52				    =	"T52";
		public	const	string		ERRORT53				    =	"T53";
        public	const	string		ERRORT50				    =	"T50";
		public  const   string		ERRORT79					=	"T79";
        public	const	string		ERRORT89				    =   "T89";
        public  const   string		ERRORD98				    =   "D98";
        public  const   string		ERRORT35				    =   "T35";
        public  const   string		ERRORC87				    =   "C87";
        public  const   string		ERRORT04				    =   "T04";
        public  const   string		ERRORT40				    =   "T40";
        public  const   string      ERRORT80                    =   "T80";
        public  const   string      ERRORC03                    =   "C03";
		public  const   string      ERRORC89                    =   "C89";
		public  const   string      ERRORT06                    =   "T06";
        
        public  const   string		ELEMENTCURRENCYNAME 		= "ELEMENTCURRENCYNAME";
        public  const   string      PARTYIDENTIFICATION2   		= "PartyIdentification2";
        public  const   string      PARTYIDENTIFICATION3   		= "PartyIdentification3";
		public  const   string		SWIFTNETWORKRULET79			= "SWIFTNetworkRuleT79";
        public  const   string		LEGACYCURRENCYDATE			= "12/31/2001";
        public const string SITCURRENCYDATE = "12/31/2006";
        		
    }
}