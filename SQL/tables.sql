use currencychecker;

CREATE TABLE ApiRequests (
request_id INT AUTO_INCREMENT PRIMARY KEY,
start_change_id VARCHAR(100),
end_change_id VARCHAR(100),
success bool not null,
completed_time DATETIME NOT NULL,
tabs_recorded int
);

