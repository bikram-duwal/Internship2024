insert into pl_object (table_name, name) values
('Area', 'Accessories'),
('Area', 'Blister Pack-1'),
('Department', 'IT-Department'),
('Department', 'Manufacture');

insert into pl_string (table_pid, column_type, data_value) values
(1, 'area_unique_code', 'A001'),
(1, 'area_code', 'FB02/59'),
(1, 'area_description', 'abc'),
(2, 'area_unique_code', 'A002'),
(2, 'area_code', 'FB02/PT/49'),
(2, 'area_description', 'abc');

insert into pl_integer (table_pid, column_type, data_value) values
(1, 'area_department_id', '3'),
(2, 'area_department_id', '4');

insert into pl_boolean (table_pid, column_type, data_value) values
(1, 'area_is_for_dispensing', 1),
(2, 'area_is_for_dispensing', 0),
(1, 'area_status', 1),
(2, 'area_status', 0);

insert into pl_area (
	table_pid,
	name,
	unique_code,
	area_code,
	description,
	is_for_dispensing,
	department_id,
	status)
values 
	(1, 'Accessories', 'A001', 'FB02/59', 'abc', 1, 3, 1),
	(2, 'Blister Pack-1', 'A002', 'FB02/PT/49', 'abc', 0, 4, 0);