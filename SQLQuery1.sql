CREATE FUNCTION EmailKontrol
(
    @eposta nchar(30)
)
RETURNS bit
AS
BEGIN
DECLARE @IsValidEmail bit = 0
IF (@eposta not like '%[^a-z,0-9,@,.,!,#,$,%%,&,'',*,+,--,/,=,?,^,_,`,{,|,},~]%' 
        AND @eposta like '%_@_%_.[a-z,0-9][a-z]%'
        AND @eposta NOT like '%@%@%'  
        AND @eposta NOT like '%..%'
        AND @eposta NOT like '.%'
        AND @eposta NOT like '%.'
        AND CHARINDEX('@', @eposta) <= 65
        )
    BEGIN
        SET @IsValidEmail = 1
    END
RETURN @IsValidEmail
END

