
CREATE PROCEDURE sp_get_all_area_rows
AS
BEGIN
    SET NOCOUNT ON;
    
    select 
    area.*,
    department.name as area_department_name
 from (SELECT 
    MAX(po.table_pid) AS table_pid,
    MAX(CASE WHEN column_type = 'area_unique_code' THEN data_value END) AS area_unique_code,
    MAX(po.name) AS area_name,
    MAX(CASE WHEN column_type = 'area_code' THEN data_value END) AS area_code,
    MAX(CASE WHEN column_type = 'area_description' THEN data_value END) AS area_description,
    CAST(MAX(CASE WHEN column_type = 'area_is_for_dispensing' THEN data_value END) as bit) AS area_is_for_dispensing,
    MAX(CASE WHEN column_type = 'area_department_id' THEN CAST(data_value as bigint) END) AS area_department_id,
    CAST(MAX(CASE WHEN column_type = 'area_status' THEN data_value END) as bit) AS area_status
FROM
    pl_object as po
JOIN
    (
    SELECT table_pid, column_type, data_value 
    FROM pl_string
    UNION ALL
    SELECT table_pid, column_type, CAST(data_value AS varchar) 
    FROM pl_boolean
    UNION ALL
    SELECT table_pid, column_type, CAST(data_value AS varchar) 
    FROM pl_integer
    ) AS all_rows 
ON 
    po.table_pid = all_rows.table_pid
WHERE
    po.table_name = 'Area'
GROUP BY 
    po.table_pid) as area JOIN (select * from pl_object where table_name='Department') as department on department.table_pid = area.area_department_id;
END;
