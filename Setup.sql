CREATE TABLE knights(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    name VARCHAR(255) NOT NULL comment 'knight name',
    hasGrail TINYINT NOT NULL comment 'does the knight have the grail',
    quests int NOT NULL comment 'number of quests',
    create_time DATETIME COMMENT 'create time',
    update_time DATETIME COMMENT 'update time'
) default charset utf8 comment '';

CREATE TABLE Castles(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    name VARCHAR(255) NOT NULL comment 'castle name',
    hasGrail TINYINT NOT NULL comment 'does the castle have the grail',
    create_time DATETIME COMMENT 'create time',
    update_time DATETIME COMMENT 'update time',
    knightId int NOT NULL,
    FOREIGN KEY (knightId) REFERENCES knights(id) ON DELETE CASCADE
) default charset utf8 comment '';