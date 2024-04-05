CREATE TABLE pl_object (
    table_pid bigint NOT NULL IDENTITY(1,1) PRIMARY KEY,
    table_name varchar(50),
    name varchar(50),
    created_date DateTime,
    created_by bigint,
    modified_date DateTime,
    modified_by bigint,
    deleted_date DateTime,
    deleted_by bigint
);

CREATE TABLE pl_string (
    table_pid bigint,
    column_type varchar(50),
    data_value nvarchar(max),
    FOREIGN KEY (table_pid) REFERENCES pl_object (table_pid)
);

CREATE TABLE pl_integer (
    table_pid bigint,
    column_type varchar(50),
    data_value int,
    FOREIGN KEY (table_pid) REFERENCES pl_object (table_pid)
);

CREATE TABLE pl_boolean (
    table_pid bigint,
    column_type varchar(50),
    data_value bit,
    FOREIGN KEY (table_pid) REFERENCES pl_object (table_pid)
);
CREATE TABLE pl_decimal (
    table_pid bigint,
    column_type varchar(50),
    data_value decimal,
    FOREIGN KEY (table_pid) REFERENCES pl_object (table_pid)
);

CREATE TABLE pl_area (
	id bigint primary key identity(1,1) not null,
    table_pid bigint,
    name varchar(50),
    unique_code nvarchar(max),
    area_code nvarchar(max),
    description nvarchar(max),
    is_for_dispensing bit,
    department_id bigint,
    status bit,
    [ValidFrom] DATETIME2 GENERATED ALWAYS AS ROW START,
    [ValidTo] DATETIME2 GENERATED ALWAYS AS ROW END,
    PERIOD FOR SYSTEM_TIME(ValidFrom, ValidTo),
    FOREIGN KEY (table_pid) REFERENCES pl_object(table_pid),
    FOREIGN KEY (department_id) REFERENCES pl_object(table_pid)
) WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = dbo.pl_area_history));
