-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 07 Oca 2022, 16:46:42
-- Sunucu sürümü: 8.0.17
-- PHP Sürümü: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ecms`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `blogs`
--

CREATE TABLE `blogs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `blog_title` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `blog_slug` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `blog_file` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `blog_must` int(11) DEFAULT NULL,
  `blog_content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  `blog_status` enum('0','1') COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `blogs`
--

INSERT INTO `blogs` (`id`, `created_at`, `updated_at`, `blog_title`, `blog_slug`, `blog_file`, `blog_must`, `blog_content`, `blog_status`) VALUES
(1, '2021-12-24 13:00:00', '2022-01-07 08:51:28', '23. Açık Kampüs', '23-acik-kampus', '61cb1a42a9071.jpg', 1, '<p>23. A&ccedil;ık Kamp&uuml;s</p>', '1'),
(2, '2021-12-23 13:00:00', '2022-01-07 08:51:26', 'OFKS - 64 Peyzaj Yapılarında Ahşabın Kullanımı ve Korunması', 'ofks-64-peyzaj-yapilarinda-ahsabin-kullanimi-ve-korunmasi', '61cb1a893f965.jpg', 0, '<p>OFKS - 64 Peyzaj Yapılarında Ahşabın Kullanımı ve Korunması</p>', '1'),
(3, '2021-12-22 13:00:00', '2022-01-02 10:00:59', 'Start Up', 'start-up', '61cb1ad8d218d.jpg', 2, '<p>Start Up</p>', '1'),
(4, '2021-12-22 13:00:00', '2022-01-02 10:01:00', 'Üniversitemiz Tıp Fakültesi Korosu', 'universitemiz-tip-fakultesi-korosu', '61cb1b1401d87.jpg', 3, '<p>&Uuml;niversitemiz Tıp Fak&uuml;ltesi Korosu</p>', '1'),
(5, '2021-12-21 13:00:00', '2022-01-02 10:01:00', '9. Açık Mutfak', '9-acik-mutfak', '61cb1b462fe8e.jpg', 4, '<p>9. A&ccedil;ık Mutfak</p>', '1'),
(10, '2021-12-21 13:00:00', '2022-01-02 10:01:00', 'Hayatın Renkleri', 'hayatin-renkleri', '61cb1b6fa5a1b.jpg', 5, '<p>Hayatın Renkleri</p>', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `failed_jobs`
--

CREATE TABLE `failed_jobs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `uuid` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `connection` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `queue` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `payload` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `exception` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `failed_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '2014_10_12_000000_create_users_table', 1),
(2, '2014_10_12_100000_create_password_resets_table', 1),
(3, '2019_08_19_000000_create_failed_jobs_table', 1),
(4, '2019_12_14_000001_create_personal_access_tokens_table', 1),
(5, '2021_12_18_153513_create_settings_table', 2),
(6, '2021_12_20_155214_create_blogs_table', 3);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `pages`
--

CREATE TABLE `pages` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `page_title` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `page_slug` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `page_file` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `page_must` int(11) DEFAULT NULL,
  `page_content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  `page_status` enum('0','1') CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `pages`
--

INSERT INTO `pages` (`id`, `created_at`, `updated_at`, `page_title`, `page_slug`, `page_file`, `page_must`, `page_content`, `page_status`) VALUES
(1, NULL, '2021-12-21 11:14:07', 'Page Title-01', 'page-title-01', '61c1d5b00d03a.png', 0, '<p>page Title-01</p>', '1'),
(2, NULL, '2021-12-21 11:14:07', 'Page Title-02', 'page-title-02', NULL, 1, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vehicula commodo urna, dignissim venenatis nisi condimentum varius. Vivamus molestie felis dui, quis efficitur dui scelerisque non. Donec volutpat quam ac ligula ultricies semper. Sed sit amet congue purus, nec laoreet velit. Curabitur pellentesque commodo semper. Morbi in tellus eget lectus pulvinar varius et a nisi. Maecenas pretium purus pellentesque convallis semper.\r\n\r\nVestibulum ut volutpat tellus. Vivamus posuere eleifend elit, at placerat neque. Pellentesque ac ultrices nunc. Sed eu tellus vitae ex fermentum imperdiet. Proin vehicula dolor vel lorem rhoncus elementum. Aliquam erat volutpat. Nunc in erat suscipit, euismod felis quis, volutpat diam. Sed consequat, lectus at mattis mattis, turpis est dignissim lectus, vel condimentum tortor magna sed lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Curabitur pellentesque, velit lobortis pulvinar molestie, massa lectus venenatis enim, id molestie ex neque a eros. Quisque risus tortor, consectetur quis facilisis malesuada, mattis at nulla. Sed sit amet ante blandit, blandit sapien sagittis, ultrices risus. Maecenas vitae condimentum neque, in malesuada risus.\r\n\r\nQuisque placerat tempus metus, at finibus libero varius eget. In hac habitasse platea dictumst. Nunc imperdiet leo vitae varius mattis. Aliquam vel odio pretium, pharetra nulla non, dapibus velit. Aliquam fringilla orci ut odio sodales semper. Vestibulum ac orci sodales, viverra lacus in, efficitur leo. Curabitur ac magna id magna rhoncus cursus vitae et felis. Sed dictum justo nibh, a pretium turpis tempus a. Donec tristique ex non ultrices volutpat. Curabitur condimentum sem massa, sed vestibulum quam vulputate a.\r\n\r\nMaecenas tempus aliquet risus id lobortis. Ut ex magna, luctus id mauris vitae, faucibus posuere neque. Mauris erat mauris, aliquet sed magna sed, auctor ultricies enim. Suspendisse sagittis pulvinar vestibulum. Donec semper urna in justo luctus, in maximus nibh pellentesque. Cras quis est vulputate, lobortis lectus in, sagittis ligula. Integer est libero, aliquet quis porta sit amet, vehicula vel urna. Cras vel libero faucibus augue aliquet laoreet ac id eros.\r\n\r\nFusce id laoreet ipsum, et maximus massa. Mauris vitae condimentum enim. Ut erat massa, dictum sit amet sapien ultricies, ornare maximus ex. Vestibulum aliquam enim sed ante vestibulum, sed scelerisque massa finibus. Quisque non lorem pharetra, lacinia lectus ac, venenatis lorem. Morbi at tincidunt urna. Nunc ac sapien in est finibus feugiat. Sed tempus, dui laoreet gravida gravida, erat nisl convallis augue, vitae euismod nulla dui ut diam. Fusce quis vulputate ex, sit amet semper elit. Proin eu odio fringilla, consectetur quam finibus, feugiat eros. Aliquam cursus tempus scelerisque. Curabitur ultrices venenatis metus nec lobortis. Sed quis leo non dui laoreet auctor elementum sagittis mi. Pellentesque eget aliquet felis, non sagittis lorem. Fusce scelerisque nibh ut viverra bibendum. Suspendisse id sem sapien.', '1'),
(3, NULL, '2021-12-21 11:14:04', 'Page Title-03', 'page-title-03', NULL, 2, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vehicula commodo urna, dignissim venenatis nisi condimentum varius. Vivamus molestie felis dui, quis efficitur dui scelerisque non. Donec volutpat quam ac ligula ultricies semper. Sed sit amet congue purus, nec laoreet velit. Curabitur pellentesque commodo semper. Morbi in tellus eget lectus pulvinar varius et a nisi. Maecenas pretium purus pellentesque convallis semper.\r\n\r\nVestibulum ut volutpat tellus. Vivamus posuere eleifend elit, at placerat neque. Pellentesque ac ultrices nunc. Sed eu tellus vitae ex fermentum imperdiet. Proin vehicula dolor vel lorem rhoncus elementum. Aliquam erat volutpat. Nunc in erat suscipit, euismod felis quis, volutpat diam. Sed consequat, lectus at mattis mattis, turpis est dignissim lectus, vel condimentum tortor magna sed lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Curabitur pellentesque, velit lobortis pulvinar molestie, massa lectus venenatis enim, id molestie ex neque a eros. Quisque risus tortor, consectetur quis facilisis malesuada, mattis at nulla. Sed sit amet ante blandit, blandit sapien sagittis, ultrices risus. Maecenas vitae condimentum neque, in malesuada risus.\r\n\r\nQuisque placerat tempus metus, at finibus libero varius eget. In hac habitasse platea dictumst. Nunc imperdiet leo vitae varius mattis. Aliquam vel odio pretium, pharetra nulla non, dapibus velit. Aliquam fringilla orci ut odio sodales semper. Vestibulum ac orci sodales, viverra lacus in, efficitur leo. Curabitur ac magna id magna rhoncus cursus vitae et felis. Sed dictum justo nibh, a pretium turpis tempus a. Donec tristique ex non ultrices volutpat. Curabitur condimentum sem massa, sed vestibulum quam vulputate a.\r\n\r\nMaecenas tempus aliquet risus id lobortis. Ut ex magna, luctus id mauris vitae, faucibus posuere neque. Mauris erat mauris, aliquet sed magna sed, auctor ultricies enim. Suspendisse sagittis pulvinar vestibulum. Donec semper urna in justo luctus, in maximus nibh pellentesque. Cras quis est vulputate, lobortis lectus in, sagittis ligula. Integer est libero, aliquet quis porta sit amet, vehicula vel urna. Cras vel libero faucibus augue aliquet laoreet ac id eros.\r\n\r\nFusce id laoreet ipsum, et maximus massa. Mauris vitae condimentum enim. Ut erat massa, dictum sit amet sapien ultricies, ornare maximus ex. Vestibulum aliquam enim sed ante vestibulum, sed scelerisque massa finibus. Quisque non lorem pharetra, lacinia lectus ac, venenatis lorem. Morbi at tincidunt urna. Nunc ac sapien in est finibus feugiat. Sed tempus, dui laoreet gravida gravida, erat nisl convallis augue, vitae euismod nulla dui ut diam. Fusce quis vulputate ex, sit amet semper elit. Proin eu odio fringilla, consectetur quam finibus, feugiat eros. Aliquam cursus tempus scelerisque. Curabitur ultrices venenatis metus nec lobortis. Sed quis leo non dui laoreet auctor elementum sagittis mi. Pellentesque eget aliquet felis, non sagittis lorem. Fusce scelerisque nibh ut viverra bibendum. Suspendisse id sem sapien.', '1'),
(4, NULL, '2021-12-21 11:14:04', 'Page Title-04', 'page-title-04', NULL, 3, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vehicula commodo urna, dignissim venenatis nisi condimentum varius. Vivamus molestie felis dui, quis efficitur dui scelerisque non. Donec volutpat quam ac ligula ultricies semper. Sed sit amet congue purus, nec laoreet velit. Curabitur pellentesque commodo semper. Morbi in tellus eget lectus pulvinar varius et a nisi. Maecenas pretium purus pellentesque convallis semper.\r\n\r\nVestibulum ut volutpat tellus. Vivamus posuere eleifend elit, at placerat neque. Pellentesque ac ultrices nunc. Sed eu tellus vitae ex fermentum imperdiet. Proin vehicula dolor vel lorem rhoncus elementum. Aliquam erat volutpat. Nunc in erat suscipit, euismod felis quis, volutpat diam. Sed consequat, lectus at mattis mattis, turpis est dignissim lectus, vel condimentum tortor magna sed lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Curabitur pellentesque, velit lobortis pulvinar molestie, massa lectus venenatis enim, id molestie ex neque a eros. Quisque risus tortor, consectetur quis facilisis malesuada, mattis at nulla. Sed sit amet ante blandit, blandit sapien sagittis, ultrices risus. Maecenas vitae condimentum neque, in malesuada risus.\r\n\r\nQuisque placerat tempus metus, at finibus libero varius eget. In hac habitasse platea dictumst. Nunc imperdiet leo vitae varius mattis. Aliquam vel odio pretium, pharetra nulla non, dapibus velit. Aliquam fringilla orci ut odio sodales semper. Vestibulum ac orci sodales, viverra lacus in, efficitur leo. Curabitur ac magna id magna rhoncus cursus vitae et felis. Sed dictum justo nibh, a pretium turpis tempus a. Donec tristique ex non ultrices volutpat. Curabitur condimentum sem massa, sed vestibulum quam vulputate a.\r\n\r\nMaecenas tempus aliquet risus id lobortis. Ut ex magna, luctus id mauris vitae, faucibus posuere neque. Mauris erat mauris, aliquet sed magna sed, auctor ultricies enim. Suspendisse sagittis pulvinar vestibulum. Donec semper urna in justo luctus, in maximus nibh pellentesque. Cras quis est vulputate, lobortis lectus in, sagittis ligula. Integer est libero, aliquet quis porta sit amet, vehicula vel urna. Cras vel libero faucibus augue aliquet laoreet ac id eros.\r\n\r\nFusce id laoreet ipsum, et maximus massa. Mauris vitae condimentum enim. Ut erat massa, dictum sit amet sapien ultricies, ornare maximus ex. Vestibulum aliquam enim sed ante vestibulum, sed scelerisque massa finibus. Quisque non lorem pharetra, lacinia lectus ac, venenatis lorem. Morbi at tincidunt urna. Nunc ac sapien in est finibus feugiat. Sed tempus, dui laoreet gravida gravida, erat nisl convallis augue, vitae euismod nulla dui ut diam. Fusce quis vulputate ex, sit amet semper elit. Proin eu odio fringilla, consectetur quam finibus, feugiat eros. Aliquam cursus tempus scelerisque. Curabitur ultrices venenatis metus nec lobortis. Sed quis leo non dui laoreet auctor elementum sagittis mi. Pellentesque eget aliquet felis, non sagittis lorem. Fusce scelerisque nibh ut viverra bibendum. Suspendisse id sem sapien.', '1'),
(5, NULL, '2021-12-21 11:14:04', 'Page Title-05', 'page-title-05', NULL, 4, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vehicula commodo urna, dignissim venenatis nisi condimentum varius. Vivamus molestie felis dui, quis efficitur dui scelerisque non. Donec volutpat quam ac ligula ultricies semper. Sed sit amet congue purus, nec laoreet velit. Curabitur pellentesque commodo semper. Morbi in tellus eget lectus pulvinar varius et a nisi. Maecenas pretium purus pellentesque convallis semper.\r\n\r\nVestibulum ut volutpat tellus. Vivamus posuere eleifend elit, at placerat neque. Pellentesque ac ultrices nunc. Sed eu tellus vitae ex fermentum imperdiet. Proin vehicula dolor vel lorem rhoncus elementum. Aliquam erat volutpat. Nunc in erat suscipit, euismod felis quis, volutpat diam. Sed consequat, lectus at mattis mattis, turpis est dignissim lectus, vel condimentum tortor magna sed lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Curabitur pellentesque, velit lobortis pulvinar molestie, massa lectus venenatis enim, id molestie ex neque a eros. Quisque risus tortor, consectetur quis facilisis malesuada, mattis at nulla. Sed sit amet ante blandit, blandit sapien sagittis, ultrices risus. Maecenas vitae condimentum neque, in malesuada risus.\r\n\r\nQuisque placerat tempus metus, at finibus libero varius eget. In hac habitasse platea dictumst. Nunc imperdiet leo vitae varius mattis. Aliquam vel odio pretium, pharetra nulla non, dapibus velit. Aliquam fringilla orci ut odio sodales semper. Vestibulum ac orci sodales, viverra lacus in, efficitur leo. Curabitur ac magna id magna rhoncus cursus vitae et felis. Sed dictum justo nibh, a pretium turpis tempus a. Donec tristique ex non ultrices volutpat. Curabitur condimentum sem massa, sed vestibulum quam vulputate a.\r\n\r\nMaecenas tempus aliquet risus id lobortis. Ut ex magna, luctus id mauris vitae, faucibus posuere neque. Mauris erat mauris, aliquet sed magna sed, auctor ultricies enim. Suspendisse sagittis pulvinar vestibulum. Donec semper urna in justo luctus, in maximus nibh pellentesque. Cras quis est vulputate, lobortis lectus in, sagittis ligula. Integer est libero, aliquet quis porta sit amet, vehicula vel urna. Cras vel libero faucibus augue aliquet laoreet ac id eros.\r\n\r\nFusce id laoreet ipsum, et maximus massa. Mauris vitae condimentum enim. Ut erat massa, dictum sit amet sapien ultricies, ornare maximus ex. Vestibulum aliquam enim sed ante vestibulum, sed scelerisque massa finibus. Quisque non lorem pharetra, lacinia lectus ac, venenatis lorem. Morbi at tincidunt urna. Nunc ac sapien in est finibus feugiat. Sed tempus, dui laoreet gravida gravida, erat nisl convallis augue, vitae euismod nulla dui ut diam. Fusce quis vulputate ex, sit amet semper elit. Proin eu odio fringilla, consectetur quam finibus, feugiat eros. Aliquam cursus tempus scelerisque. Curabitur ultrices venenatis metus nec lobortis. Sed quis leo non dui laoreet auctor elementum sagittis mi. Pellentesque eget aliquet felis, non sagittis lorem. Fusce scelerisque nibh ut viverra bibendum. Suspendisse id sem sapien.', '1'),
(10, NULL, '2021-12-21 11:14:04', 'Page Title-06', 'page-title-06', NULL, 5, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vehicula commodo urna, dignissim venenatis nisi condimentum varius. Vivamus molestie felis dui, quis efficitur dui scelerisque non. Donec volutpat quam ac ligula ultricies semper. Sed sit amet congue purus, nec laoreet velit. Curabitur pellentesque commodo semper. Morbi in tellus eget lectus pulvinar varius et a nisi. Maecenas pretium purus pellentesque convallis semper.\r\n\r\nVestibulum ut volutpat tellus. Vivamus posuere eleifend elit, at placerat neque. Pellentesque ac ultrices nunc. Sed eu tellus vitae ex fermentum imperdiet. Proin vehicula dolor vel lorem rhoncus elementum. Aliquam erat volutpat. Nunc in erat suscipit, euismod felis quis, volutpat diam. Sed consequat, lectus at mattis mattis, turpis est dignissim lectus, vel condimentum tortor magna sed lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Curabitur pellentesque, velit lobortis pulvinar molestie, massa lectus venenatis enim, id molestie ex neque a eros. Quisque risus tortor, consectetur quis facilisis malesuada, mattis at nulla. Sed sit amet ante blandit, blandit sapien sagittis, ultrices risus. Maecenas vitae condimentum neque, in malesuada risus.\r\n\r\nQuisque placerat tempus metus, at finibus libero varius eget. In hac habitasse platea dictumst. Nunc imperdiet leo vitae varius mattis. Aliquam vel odio pretium, pharetra nulla non, dapibus velit. Aliquam fringilla orci ut odio sodales semper. Vestibulum ac orci sodales, viverra lacus in, efficitur leo. Curabitur ac magna id magna rhoncus cursus vitae et felis. Sed dictum justo nibh, a pretium turpis tempus a. Donec tristique ex non ultrices volutpat. Curabitur condimentum sem massa, sed vestibulum quam vulputate a.\r\n\r\nMaecenas tempus aliquet risus id lobortis. Ut ex magna, luctus id mauris vitae, faucibus posuere neque. Mauris erat mauris, aliquet sed magna sed, auctor ultricies enim. Suspendisse sagittis pulvinar vestibulum. Donec semper urna in justo luctus, in maximus nibh pellentesque. Cras quis est vulputate, lobortis lectus in, sagittis ligula. Integer est libero, aliquet quis porta sit amet, vehicula vel urna. Cras vel libero faucibus augue aliquet laoreet ac id eros.\r\n\r\nFusce id laoreet ipsum, et maximus massa. Mauris vitae condimentum enim. Ut erat massa, dictum sit amet sapien ultricies, ornare maximus ex. Vestibulum aliquam enim sed ante vestibulum, sed scelerisque massa finibus. Quisque non lorem pharetra, lacinia lectus ac, venenatis lorem. Morbi at tincidunt urna. Nunc ac sapien in est finibus feugiat. Sed tempus, dui laoreet gravida gravida, erat nisl convallis augue, vitae euismod nulla dui ut diam. Fusce quis vulputate ex, sit amet semper elit. Proin eu odio fringilla, consectetur quam finibus, feugiat eros. Aliquam cursus tempus scelerisque. Curabitur ultrices venenatis metus nec lobortis. Sed quis leo non dui laoreet auctor elementum sagittis mi. Pellentesque eget aliquet felis, non sagittis lorem. Fusce scelerisque nibh ut viverra bibendum. Suspendisse id sem sapien.', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personal_access_tokens`
--

CREATE TABLE `personal_access_tokens` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `tokenable_type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tokenable_id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `abilities` text COLLATE utf8mb4_unicode_ci,
  `last_used_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `settings`
--

CREATE TABLE `settings` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `settings_description` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `settings_key` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `settings_value` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `settings_type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `settings_must` int(11) NOT NULL,
  `settings_delete` enum('0','1') COLLATE utf8mb4_unicode_ci NOT NULL,
  `settings_status` enum('0','1') COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `settings`
--

INSERT INTO `settings` (`id`, `created_at`, `updated_at`, `settings_description`, `settings_key`, `settings_value`, `settings_type`, `settings_must`, `settings_delete`, `settings_status`) VALUES
(1, NULL, '2021-12-28 10:29:22', 'Başlık', 'title', 'Düzce Üniversitesi', 'text', 0, '0', '1'),
(2, NULL, '2021-12-28 11:36:43', 'Açıklama', 'description', 'Düzce Üniversitesi Web Sitesi Ayarları', 'text', 1, '0', '1'),
(3, NULL, '2021-12-28 11:35:49', 'Logo', 'logo', '61cb20c56df6f.PNG', 'file', 2, '0', '1'),
(4, NULL, '2021-12-20 09:17:46', 'Icon', 'icon', '61c0746a3e074.png', 'file', 3, '0', '1'),
(5, NULL, '2022-01-03 09:13:31', 'Anahtar Kelimeler', 'keywords', 'laravel,Düzce Üniversitesi,esra tekir', 'text', 4, '0', '1'),
(6, NULL, '2021-12-27 10:53:11', 'Telefon Sabit', 'phone_sabit', '0850 800 81 81', 'text', 5, '0', '1'),
(7, NULL, '2021-12-19 13:58:26', 'Telefon GSM', 'phone_gsm', '0543 XXX XX XX', 'text', 6, '0', '1'),
(8, NULL, '2021-12-19 13:58:24', 'Mail', 'mail', 'esratekir02@gmail.com', 'text', 7, '0', '1'),
(9, NULL, '2021-12-27 10:52:41', 'İlçe', 'ilçe', 'Merkez', 'text', 8, '0', '1'),
(10, NULL, '2021-12-27 10:52:08', 'İl', 'il', 'Düzce', 'textarea', 9, '0', '1'),
(11, NULL, '2021-12-27 10:57:06', 'Açık Adres', 'adres', 'ANA KAMPÜS\r\nDüzce Üniversitesi Konuralp Yerleşkesi Yörük Mah. Merkez/DÜZCE, 81620', 'textarea', 10, '0', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sliders`
--

CREATE TABLE `sliders` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `slider_title` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `slider_slug` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `slider_url` varchar(255) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `slider_file` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `slider_must` int(11) DEFAULT NULL,
  `slider_content` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  `slider_status` enum('0','1') CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `sliders`
--

INSERT INTO `sliders` (`id`, `created_at`, `updated_at`, `slider_title`, `slider_slug`, `slider_url`, `slider_file`, `slider_must`, `slider_content`, `slider_status`) VALUES
(1, NULL, '2022-01-05 11:17:47', 'Slider Title-01', 'slider-title-01', 'http://duzce.edu.tr', '61cb1be2e033f.jpg', 1, '<p>Slider Title-01</p>', '1'),
(2, NULL, '2022-01-05 11:17:47', 'Slider Title-02', 'slider-title-02', 'http://duzce.edu.tr', '61cb1c1a4ef08.jpg', 2, '<p>Slider Title-02</p>', '1'),
(3, NULL, '2022-01-05 11:17:48', 'Slider Title-03', 'slider-title-03', 'http://duzce.edu.tr', '61cb1c56d9028.jpg', 3, '<p>Slider Title-03</p>', '1'),
(18, NULL, '2022-01-05 11:17:47', 'Slider Title-04', 'slider-title-04', 'http://duzce.edu.tr', '61cf49082786c.png', 0, '<p>Slider Title-04</p>', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `user_file` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `role` enum('admin','user') COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'admin',
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `remember_token` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `user_status` enum('0','1') COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`id`, `user_file`, `role`, `name`, `email`, `email_verified_at`, `password`, `remember_token`, `created_at`, `updated_at`, `user_status`) VALUES
(2, '61c3245b09cc0.png', 'admin', 'Esra Tekir', 'esratekir02@gmail.com', NULL, '$2y$10$QtJ7vAW4MNrU4znhVWDdT.DshtbzdVRb3DKvDLzvCv3sTcm2DXF0i', NULL, '2021-12-22 07:02:07', '2021-12-22 10:12:59', '1');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `blogs`
--
ALTER TABLE `blogs`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `failed_jobs`
--
ALTER TABLE `failed_jobs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `failed_jobs_uuid_unique` (`uuid`);

--
-- Tablo için indeksler `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `pages`
--
ALTER TABLE `pages`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Tablo için indeksler `personal_access_tokens`
--
ALTER TABLE `personal_access_tokens`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `personal_access_tokens_token_unique` (`token`),
  ADD KEY `personal_access_tokens_tokenable_type_tokenable_id_index` (`tokenable_type`,`tokenable_id`);

--
-- Tablo için indeksler `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sliders`
--
ALTER TABLE `sliders`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `blogs`
--
ALTER TABLE `blogs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Tablo için AUTO_INCREMENT değeri `failed_jobs`
--
ALTER TABLE `failed_jobs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `pages`
--
ALTER TABLE `pages`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Tablo için AUTO_INCREMENT değeri `personal_access_tokens`
--
ALTER TABLE `personal_access_tokens`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `settings`
--
ALTER TABLE `settings`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Tablo için AUTO_INCREMENT değeri `sliders`
--
ALTER TABLE `sliders`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Tablo için AUTO_INCREMENT değeri `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
